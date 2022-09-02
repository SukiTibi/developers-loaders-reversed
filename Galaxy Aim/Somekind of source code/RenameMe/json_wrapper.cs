using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace RenameMe
{
	// Token: 0x0200003F RID: 63
	public class json_wrapper
	{
		// Token: 0x06000128 RID: 296 RVA: 0x000027D5 File Offset: 0x000009D5
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000072B4 File Offset: 0x000054B4
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00007304 File Offset: 0x00005504
		public object string_to_object(string json)
		{
			object result;
			using (MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(json)))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000027F2 File Offset: 0x000009F2
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000364 RID: 868
		private DataContractJsonSerializer serializer;

		// Token: 0x04000365 RID: 869
		private object current_object;
	}
}
