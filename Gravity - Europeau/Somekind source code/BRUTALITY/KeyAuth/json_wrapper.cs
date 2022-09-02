using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x0200000F RID: 15
	public class json_wrapper
	{
		// Token: 0x0600008C RID: 140 RVA: 0x0000247C File Offset: 0x0000067C
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000420C File Offset: 0x0000240C
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

		// Token: 0x0600008E RID: 142 RVA: 0x0000425C File Offset: 0x0000245C
		public object string_to_object(string json)
		{
			object result;
			using (MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(json)))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002499 File Offset: 0x00000699
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000038 RID: 56
		private DataContractJsonSerializer serializer;

		// Token: 0x04000039 RID: 57
		private object current_object;
	}
}
