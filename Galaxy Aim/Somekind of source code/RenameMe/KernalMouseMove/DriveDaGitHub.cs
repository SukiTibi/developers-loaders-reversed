using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp;
using Microsoft.Win32;

namespace KernalMouseMove
{
	// Token: 0x02000003 RID: 3
	internal class DriveDaGitHub
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000212A File Offset: 0x0000032A
		private static void SairDoPrograma(string informacoes)
		{
			MessageBox.Show(informacoes, "Error");
			Environment.Exit(0);
			Process.GetCurrentProcess().Kill();
			File.Create("a??|\\\\????@@1!:").Close();
			goto IL_2B;
			for (;;)
			{
				IL_2B:
				goto IL_2B;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000036F4 File Offset: 0x000018F4
		public static void VGK()
		{
			int num = 0;
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			for (int i = 0; i < commandLineArgs.Length; i++)
			{
				int.TryParse(commandLineArgs[i], out num);
			}
			if (num != 0)
			{
				DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.VerificarPid(num);
				return;
			}
			DriveDaGitHub.TecnicasBasicas.AntiProxy();
			DriveDaGitHub.TecnicasAvancadas.IniciadoPeloExplorer();
			DriveDaGitHub.TecnicasBasicas.VerificarModificacaoDoArquivo();
			DriveDaGitHub.TecnicasBasicas.AntiDepurador();
			DriveDaGitHub.TecnicasBasicas.MatarDepurador();
			DriveDaGitHub.TecnicasAvancadas.Kernel.AntiDebugger();
			DriveDaGitHub.TecnicasAvancadas.Threads.OcultarTodosOsThreads();
			DriveDaGitHub.TecnicasAvancadas.Memoria.IniciarProtecaoVirtual();
			if (num == 0)
			{
				DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.AutoDepurar(num);
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly string local = Assembly.GetEntryAssembly().Location;

		// Token: 0x04000002 RID: 2
		private static readonly string diaDaCompilacao = "24/08/22";

		// Token: 0x02000004 RID: 4
		public enum NtStatus : uint
		{
			// Token: 0x04000004 RID: 4
			Success,
			// Token: 0x04000005 RID: 5
			Wait0 = 0U,
			// Token: 0x04000006 RID: 6
			Wait1,
			// Token: 0x04000007 RID: 7
			Wait2,
			// Token: 0x04000008 RID: 8
			Wait3,
			// Token: 0x04000009 RID: 9
			Wait63 = 63U,
			// Token: 0x0400000A RID: 10
			Abandoned = 128U,
			// Token: 0x0400000B RID: 11
			AbandonedWait0 = 128U,
			// Token: 0x0400000C RID: 12
			AbandonedWait1,
			// Token: 0x0400000D RID: 13
			AbandonedWait2,
			// Token: 0x0400000E RID: 14
			AbandonedWait3,
			// Token: 0x0400000F RID: 15
			AbandonedWait63 = 191U,
			// Token: 0x04000010 RID: 16
			UserApc,
			// Token: 0x04000011 RID: 17
			KernelApc = 256U,
			// Token: 0x04000012 RID: 18
			Alerted,
			// Token: 0x04000013 RID: 19
			Timeout,
			// Token: 0x04000014 RID: 20
			Pending,
			// Token: 0x04000015 RID: 21
			Reparse,
			// Token: 0x04000016 RID: 22
			MoreEntries,
			// Token: 0x04000017 RID: 23
			NotAllAssigned,
			// Token: 0x04000018 RID: 24
			SomeNotMapped,
			// Token: 0x04000019 RID: 25
			OpLockBreakInProgress,
			// Token: 0x0400001A RID: 26
			VolumeMounted,
			// Token: 0x0400001B RID: 27
			RxActCommitted,
			// Token: 0x0400001C RID: 28
			NotifyCleanup,
			// Token: 0x0400001D RID: 29
			NotifyEnumDir,
			// Token: 0x0400001E RID: 30
			NoQuotasForAccount,
			// Token: 0x0400001F RID: 31
			PrimaryTransportConnectFailed,
			// Token: 0x04000020 RID: 32
			PageFaultTransition = 272U,
			// Token: 0x04000021 RID: 33
			PageFaultDemandZero,
			// Token: 0x04000022 RID: 34
			PageFaultCopyOnWrite,
			// Token: 0x04000023 RID: 35
			PageFaultGuardPage,
			// Token: 0x04000024 RID: 36
			PageFaultPagingFile,
			// Token: 0x04000025 RID: 37
			CrashDump = 278U,
			// Token: 0x04000026 RID: 38
			ReparseObject = 280U,
			// Token: 0x04000027 RID: 39
			NothingToTerminate = 290U,
			// Token: 0x04000028 RID: 40
			ProcessNotInJob,
			// Token: 0x04000029 RID: 41
			ProcessInJob,
			// Token: 0x0400002A RID: 42
			ProcessCloned = 297U,
			// Token: 0x0400002B RID: 43
			FileLockedWithOnlyReaders,
			// Token: 0x0400002C RID: 44
			FileLockedWithWriters,
			// Token: 0x0400002D RID: 45
			Informational = 1073741824U,
			// Token: 0x0400002E RID: 46
			ObjectNameExists = 1073741824U,
			// Token: 0x0400002F RID: 47
			ThreadWasSuspended,
			// Token: 0x04000030 RID: 48
			WorkingSetLimitRange,
			// Token: 0x04000031 RID: 49
			ImageNotAtBase,
			// Token: 0x04000032 RID: 50
			RegistryRecovered = 1073741833U,
			// Token: 0x04000033 RID: 51
			Warning = 2147483648U,
			// Token: 0x04000034 RID: 52
			GuardPageViolation,
			// Token: 0x04000035 RID: 53
			DatatypeMisalignment,
			// Token: 0x04000036 RID: 54
			Breakpoint,
			// Token: 0x04000037 RID: 55
			SingleStep,
			// Token: 0x04000038 RID: 56
			BufferOverflow,
			// Token: 0x04000039 RID: 57
			NoMoreFiles,
			// Token: 0x0400003A RID: 58
			HandlesClosed = 2147483658U,
			// Token: 0x0400003B RID: 59
			PartialCopy = 2147483661U,
			// Token: 0x0400003C RID: 60
			DeviceBusy = 2147483665U,
			// Token: 0x0400003D RID: 61
			InvalidEaName = 2147483667U,
			// Token: 0x0400003E RID: 62
			EaListInconsistent,
			// Token: 0x0400003F RID: 63
			NoMoreEntries = 2147483674U,
			// Token: 0x04000040 RID: 64
			LongJump = 2147483686U,
			// Token: 0x04000041 RID: 65
			DllMightBeInsecure = 2147483691U,
			// Token: 0x04000042 RID: 66
			Error = 3221225472U,
			// Token: 0x04000043 RID: 67
			Unsuccessful,
			// Token: 0x04000044 RID: 68
			NotImplemented,
			// Token: 0x04000045 RID: 69
			InvalidInfoClass,
			// Token: 0x04000046 RID: 70
			InfoLengthMismatch,
			// Token: 0x04000047 RID: 71
			AccessViolation,
			// Token: 0x04000048 RID: 72
			InPageError,
			// Token: 0x04000049 RID: 73
			PagefileQuota,
			// Token: 0x0400004A RID: 74
			InvalidHandle,
			// Token: 0x0400004B RID: 75
			BadInitialStack,
			// Token: 0x0400004C RID: 76
			BadInitialPc,
			// Token: 0x0400004D RID: 77
			InvalidCid,
			// Token: 0x0400004E RID: 78
			TimerNotCanceled,
			// Token: 0x0400004F RID: 79
			InvalidParameter,
			// Token: 0x04000050 RID: 80
			NoSuchDevice,
			// Token: 0x04000051 RID: 81
			NoSuchFile,
			// Token: 0x04000052 RID: 82
			InvalidDeviceRequest,
			// Token: 0x04000053 RID: 83
			EndOfFile,
			// Token: 0x04000054 RID: 84
			WrongVolume,
			// Token: 0x04000055 RID: 85
			NoMediaInDevice,
			// Token: 0x04000056 RID: 86
			NoMemory = 3221225495U,
			// Token: 0x04000057 RID: 87
			NotMappedView = 3221225497U,
			// Token: 0x04000058 RID: 88
			UnableToFreeVm,
			// Token: 0x04000059 RID: 89
			UnableToDeleteSection,
			// Token: 0x0400005A RID: 90
			IllegalInstruction = 3221225501U,
			// Token: 0x0400005B RID: 91
			AlreadyCommitted = 3221225505U,
			// Token: 0x0400005C RID: 92
			AccessDenied,
			// Token: 0x0400005D RID: 93
			BufferTooSmall,
			// Token: 0x0400005E RID: 94
			ObjectTypeMismatch,
			// Token: 0x0400005F RID: 95
			NonContinuableException,
			// Token: 0x04000060 RID: 96
			BadStack = 3221225512U,
			// Token: 0x04000061 RID: 97
			NotLocked = 3221225514U,
			// Token: 0x04000062 RID: 98
			NotCommitted = 3221225517U,
			// Token: 0x04000063 RID: 99
			InvalidParameterMix = 3221225520U,
			// Token: 0x04000064 RID: 100
			ObjectNameInvalid = 3221225523U,
			// Token: 0x04000065 RID: 101
			ObjectNameNotFound,
			// Token: 0x04000066 RID: 102
			ObjectNameCollision,
			// Token: 0x04000067 RID: 103
			ObjectPathInvalid = 3221225529U,
			// Token: 0x04000068 RID: 104
			ObjectPathNotFound,
			// Token: 0x04000069 RID: 105
			ObjectPathSyntaxBad,
			// Token: 0x0400006A RID: 106
			DataOverrun,
			// Token: 0x0400006B RID: 107
			DataLate,
			// Token: 0x0400006C RID: 108
			DataError,
			// Token: 0x0400006D RID: 109
			CrcError,
			// Token: 0x0400006E RID: 110
			SectionTooBig,
			// Token: 0x0400006F RID: 111
			PortConnectionRefused,
			// Token: 0x04000070 RID: 112
			InvalidPortHandle,
			// Token: 0x04000071 RID: 113
			SharingViolation,
			// Token: 0x04000072 RID: 114
			QuotaExceeded,
			// Token: 0x04000073 RID: 115
			InvalidPageProtection,
			// Token: 0x04000074 RID: 116
			MutantNotOwned,
			// Token: 0x04000075 RID: 117
			SemaphoreLimitExceeded,
			// Token: 0x04000076 RID: 118
			PortAlreadySet,
			// Token: 0x04000077 RID: 119
			SectionNotImage,
			// Token: 0x04000078 RID: 120
			SuspendCountExceeded,
			// Token: 0x04000079 RID: 121
			ThreadIsTerminating,
			// Token: 0x0400007A RID: 122
			BadWorkingSetLimit,
			// Token: 0x0400007B RID: 123
			IncompatibleFileMap,
			// Token: 0x0400007C RID: 124
			SectionProtection,
			// Token: 0x0400007D RID: 125
			EasNotSupported,
			// Token: 0x0400007E RID: 126
			EaTooLarge,
			// Token: 0x0400007F RID: 127
			NonExistentEaEntry,
			// Token: 0x04000080 RID: 128
			NoEasOnFile,
			// Token: 0x04000081 RID: 129
			EaCorruptError,
			// Token: 0x04000082 RID: 130
			FileLockConflict,
			// Token: 0x04000083 RID: 131
			LockNotGranted,
			// Token: 0x04000084 RID: 132
			DeletePending,
			// Token: 0x04000085 RID: 133
			CtlFileNotSupported,
			// Token: 0x04000086 RID: 134
			UnknownRevision,
			// Token: 0x04000087 RID: 135
			RevisionMismatch,
			// Token: 0x04000088 RID: 136
			InvalidOwner,
			// Token: 0x04000089 RID: 137
			InvalidPrimaryGroup,
			// Token: 0x0400008A RID: 138
			NoImpersonationToken,
			// Token: 0x0400008B RID: 139
			CantDisableMandatory,
			// Token: 0x0400008C RID: 140
			NoLogonServers,
			// Token: 0x0400008D RID: 141
			NoSuchLogonSession,
			// Token: 0x0400008E RID: 142
			NoSuchPrivilege,
			// Token: 0x0400008F RID: 143
			PrivilegeNotHeld,
			// Token: 0x04000090 RID: 144
			InvalidAccountName,
			// Token: 0x04000091 RID: 145
			UserExists,
			// Token: 0x04000092 RID: 146
			NoSuchUser,
			// Token: 0x04000093 RID: 147
			GroupExists,
			// Token: 0x04000094 RID: 148
			NoSuchGroup,
			// Token: 0x04000095 RID: 149
			MemberInGroup,
			// Token: 0x04000096 RID: 150
			MemberNotInGroup,
			// Token: 0x04000097 RID: 151
			LastAdmin,
			// Token: 0x04000098 RID: 152
			WrongPassword,
			// Token: 0x04000099 RID: 153
			IllFormedPassword,
			// Token: 0x0400009A RID: 154
			PasswordRestriction,
			// Token: 0x0400009B RID: 155
			LogonFailure,
			// Token: 0x0400009C RID: 156
			AccountRestriction,
			// Token: 0x0400009D RID: 157
			InvalidLogonHours,
			// Token: 0x0400009E RID: 158
			InvalidWorkstation,
			// Token: 0x0400009F RID: 159
			PasswordExpired,
			// Token: 0x040000A0 RID: 160
			AccountDisabled,
			// Token: 0x040000A1 RID: 161
			NoneMapped,
			// Token: 0x040000A2 RID: 162
			TooManyLuidsRequested,
			// Token: 0x040000A3 RID: 163
			LuidsExhausted,
			// Token: 0x040000A4 RID: 164
			InvalidSubAuthority,
			// Token: 0x040000A5 RID: 165
			InvalidAcl,
			// Token: 0x040000A6 RID: 166
			InvalidSid,
			// Token: 0x040000A7 RID: 167
			InvalidSecurityDescr,
			// Token: 0x040000A8 RID: 168
			ProcedureNotFound,
			// Token: 0x040000A9 RID: 169
			InvalidImageFormat,
			// Token: 0x040000AA RID: 170
			NoToken,
			// Token: 0x040000AB RID: 171
			BadInheritanceAcl,
			// Token: 0x040000AC RID: 172
			RangeNotLocked,
			// Token: 0x040000AD RID: 173
			DiskFull,
			// Token: 0x040000AE RID: 174
			ServerDisabled,
			// Token: 0x040000AF RID: 175
			ServerNotDisabled,
			// Token: 0x040000B0 RID: 176
			TooManyGuidsRequested,
			// Token: 0x040000B1 RID: 177
			GuidsExhausted,
			// Token: 0x040000B2 RID: 178
			InvalidIdAuthority,
			// Token: 0x040000B3 RID: 179
			AgentsExhausted,
			// Token: 0x040000B4 RID: 180
			InvalidVolumeLabel,
			// Token: 0x040000B5 RID: 181
			SectionNotExtended,
			// Token: 0x040000B6 RID: 182
			NotMappedData,
			// Token: 0x040000B7 RID: 183
			ResourceDataNotFound,
			// Token: 0x040000B8 RID: 184
			ResourceTypeNotFound,
			// Token: 0x040000B9 RID: 185
			ResourceNameNotFound,
			// Token: 0x040000BA RID: 186
			ArrayBoundsExceeded,
			// Token: 0x040000BB RID: 187
			FloatDenormalOperand,
			// Token: 0x040000BC RID: 188
			FloatDivideByZero,
			// Token: 0x040000BD RID: 189
			FloatInexactResult,
			// Token: 0x040000BE RID: 190
			FloatInvalidOperation,
			// Token: 0x040000BF RID: 191
			FloatOverflow,
			// Token: 0x040000C0 RID: 192
			FloatStackCheck,
			// Token: 0x040000C1 RID: 193
			FloatUnderflow,
			// Token: 0x040000C2 RID: 194
			IntegerDivideByZero,
			// Token: 0x040000C3 RID: 195
			IntegerOverflow,
			// Token: 0x040000C4 RID: 196
			PrivilegedInstruction,
			// Token: 0x040000C5 RID: 197
			TooManyPagingFiles,
			// Token: 0x040000C6 RID: 198
			FileInvalid,
			// Token: 0x040000C7 RID: 199
			InstanceNotAvailable = 3221225643U,
			// Token: 0x040000C8 RID: 200
			PipeNotAvailable,
			// Token: 0x040000C9 RID: 201
			InvalidPipeState,
			// Token: 0x040000CA RID: 202
			PipeBusy,
			// Token: 0x040000CB RID: 203
			IllegalFunction,
			// Token: 0x040000CC RID: 204
			PipeDisconnected,
			// Token: 0x040000CD RID: 205
			PipeClosing,
			// Token: 0x040000CE RID: 206
			PipeConnected,
			// Token: 0x040000CF RID: 207
			PipeListening,
			// Token: 0x040000D0 RID: 208
			InvalidReadMode,
			// Token: 0x040000D1 RID: 209
			IoTimeout,
			// Token: 0x040000D2 RID: 210
			FileForcedClosed,
			// Token: 0x040000D3 RID: 211
			ProfilingNotStarted,
			// Token: 0x040000D4 RID: 212
			ProfilingNotStopped,
			// Token: 0x040000D5 RID: 213
			NotSameDevice = 3221225684U,
			// Token: 0x040000D6 RID: 214
			FileRenamed,
			// Token: 0x040000D7 RID: 215
			CantWait = 3221225688U,
			// Token: 0x040000D8 RID: 216
			PipeEmpty,
			// Token: 0x040000D9 RID: 217
			CantTerminateSelf = 3221225691U,
			// Token: 0x040000DA RID: 218
			InternalError = 3221225701U,
			// Token: 0x040000DB RID: 219
			InvalidParameter1 = 3221225711U,
			// Token: 0x040000DC RID: 220
			InvalidParameter2,
			// Token: 0x040000DD RID: 221
			InvalidParameter3,
			// Token: 0x040000DE RID: 222
			InvalidParameter4,
			// Token: 0x040000DF RID: 223
			InvalidParameter5,
			// Token: 0x040000E0 RID: 224
			InvalidParameter6,
			// Token: 0x040000E1 RID: 225
			InvalidParameter7,
			// Token: 0x040000E2 RID: 226
			InvalidParameter8,
			// Token: 0x040000E3 RID: 227
			InvalidParameter9,
			// Token: 0x040000E4 RID: 228
			InvalidParameter10,
			// Token: 0x040000E5 RID: 229
			InvalidParameter11,
			// Token: 0x040000E6 RID: 230
			InvalidParameter12,
			// Token: 0x040000E7 RID: 231
			MappedFileSizeZero = 3221225758U,
			// Token: 0x040000E8 RID: 232
			TooManyOpenedFiles,
			// Token: 0x040000E9 RID: 233
			Cancelled,
			// Token: 0x040000EA RID: 234
			CannotDelete,
			// Token: 0x040000EB RID: 235
			InvalidComputerName,
			// Token: 0x040000EC RID: 236
			FileDeleted,
			// Token: 0x040000ED RID: 237
			SpecialAccount,
			// Token: 0x040000EE RID: 238
			SpecialGroup,
			// Token: 0x040000EF RID: 239
			SpecialUser,
			// Token: 0x040000F0 RID: 240
			MembersPrimaryGroup,
			// Token: 0x040000F1 RID: 241
			FileClosed,
			// Token: 0x040000F2 RID: 242
			TooManyThreads,
			// Token: 0x040000F3 RID: 243
			ThreadNotInProcess,
			// Token: 0x040000F4 RID: 244
			TokenAlreadyInUse,
			// Token: 0x040000F5 RID: 245
			PagefileQuotaExceeded,
			// Token: 0x040000F6 RID: 246
			CommitmentLimit,
			// Token: 0x040000F7 RID: 247
			InvalidImageLeFormat,
			// Token: 0x040000F8 RID: 248
			InvalidImageNotMz,
			// Token: 0x040000F9 RID: 249
			InvalidImageProtect,
			// Token: 0x040000FA RID: 250
			InvalidImageWin16,
			// Token: 0x040000FB RID: 251
			LogonServer,
			// Token: 0x040000FC RID: 252
			DifferenceAtDc,
			// Token: 0x040000FD RID: 253
			SynchronizationRequired,
			// Token: 0x040000FE RID: 254
			DllNotFound,
			// Token: 0x040000FF RID: 255
			IoPrivilegeFailed = 3221225783U,
			// Token: 0x04000100 RID: 256
			OrdinalNotFound,
			// Token: 0x04000101 RID: 257
			EntryPointNotFound,
			// Token: 0x04000102 RID: 258
			ControlCExit,
			// Token: 0x04000103 RID: 259
			PortNotSet = 3221226323U,
			// Token: 0x04000104 RID: 260
			DebuggerInactive,
			// Token: 0x04000105 RID: 261
			CallbackBypass = 3221226755U,
			// Token: 0x04000106 RID: 262
			PortClosed = 3221227264U,
			// Token: 0x04000107 RID: 263
			MessageLost,
			// Token: 0x04000108 RID: 264
			InvalidMessage,
			// Token: 0x04000109 RID: 265
			RequestCanceled,
			// Token: 0x0400010A RID: 266
			RecursiveDispatch,
			// Token: 0x0400010B RID: 267
			LpcReceiveBufferExpected,
			// Token: 0x0400010C RID: 268
			LpcInvalidConnectionUsage,
			// Token: 0x0400010D RID: 269
			LpcRequestsNotAllowed,
			// Token: 0x0400010E RID: 270
			ResourceInUse,
			// Token: 0x0400010F RID: 271
			ProcessIsProtected = 3221227282U,
			// Token: 0x04000110 RID: 272
			VolumeDirty = 3221227526U,
			// Token: 0x04000111 RID: 273
			FileCheckedOut = 3221227777U,
			// Token: 0x04000112 RID: 274
			CheckOutRequired,
			// Token: 0x04000113 RID: 275
			BadFileType,
			// Token: 0x04000114 RID: 276
			FileTooLarge,
			// Token: 0x04000115 RID: 277
			FormsAuthRequired,
			// Token: 0x04000116 RID: 278
			VirusInfected,
			// Token: 0x04000117 RID: 279
			VirusDeleted,
			// Token: 0x04000118 RID: 280
			TransactionalConflict = 3222863873U,
			// Token: 0x04000119 RID: 281
			InvalidTransaction,
			// Token: 0x0400011A RID: 282
			TransactionNotActive,
			// Token: 0x0400011B RID: 283
			TmInitializationFailed,
			// Token: 0x0400011C RID: 284
			RmNotActive,
			// Token: 0x0400011D RID: 285
			RmMetadataCorrupt,
			// Token: 0x0400011E RID: 286
			TransactionNotJoined,
			// Token: 0x0400011F RID: 287
			DirectoryNotRm,
			// Token: 0x04000120 RID: 288
			CouldNotResizeLog,
			// Token: 0x04000121 RID: 289
			TransactionsUnsupportedRemote,
			// Token: 0x04000122 RID: 290
			LogResizeInvalidSize,
			// Token: 0x04000123 RID: 291
			RemoteFileVersionMismatch,
			// Token: 0x04000124 RID: 292
			CrmProtocolAlreadyExists = 3222863887U,
			// Token: 0x04000125 RID: 293
			TransactionPropagationFailed,
			// Token: 0x04000126 RID: 294
			CrmProtocolNotFound,
			// Token: 0x04000127 RID: 295
			TransactionSuperiorExists,
			// Token: 0x04000128 RID: 296
			TransactionRequestNotValid,
			// Token: 0x04000129 RID: 297
			TransactionNotRequested,
			// Token: 0x0400012A RID: 298
			TransactionAlreadyAborted,
			// Token: 0x0400012B RID: 299
			TransactionAlreadyCommitted,
			// Token: 0x0400012C RID: 300
			TransactionInvalidMarshallBuffer,
			// Token: 0x0400012D RID: 301
			CurrentTransactionNotValid,
			// Token: 0x0400012E RID: 302
			LogGrowthFailed,
			// Token: 0x0400012F RID: 303
			ObjectNoLongerExists = 3222863905U,
			// Token: 0x04000130 RID: 304
			StreamMiniversionNotFound,
			// Token: 0x04000131 RID: 305
			StreamMiniversionNotValid,
			// Token: 0x04000132 RID: 306
			MiniversionInaccessibleFromSpecifiedTransaction,
			// Token: 0x04000133 RID: 307
			CantOpenMiniversionWithModifyIntent,
			// Token: 0x04000134 RID: 308
			CantCreateMoreStreamMiniversions,
			// Token: 0x04000135 RID: 309
			HandleNoLongerValid = 3222863912U,
			// Token: 0x04000136 RID: 310
			NoTxfMetadata,
			// Token: 0x04000137 RID: 311
			LogCorruptionDetected = 3222863920U,
			// Token: 0x04000138 RID: 312
			CantRecoverWithHandleOpen,
			// Token: 0x04000139 RID: 313
			RmDisconnected,
			// Token: 0x0400013A RID: 314
			EnlistmentNotSuperior,
			// Token: 0x0400013B RID: 315
			RecoveryNotNeeded,
			// Token: 0x0400013C RID: 316
			RmAlreadyStarted,
			// Token: 0x0400013D RID: 317
			FileIdentityNotPersistent,
			// Token: 0x0400013E RID: 318
			CantBreakTransactionalDependency,
			// Token: 0x0400013F RID: 319
			CantCrossRmBoundary,
			// Token: 0x04000140 RID: 320
			TxfDirNotEmpty,
			// Token: 0x04000141 RID: 321
			IndoubtTransactionsExist,
			// Token: 0x04000142 RID: 322
			TmVolatile,
			// Token: 0x04000143 RID: 323
			RollbackTimerExpired,
			// Token: 0x04000144 RID: 324
			TxfAttributeCorrupt,
			// Token: 0x04000145 RID: 325
			EfsNotAllowedInTransaction,
			// Token: 0x04000146 RID: 326
			TransactionalOpenNotAllowed,
			// Token: 0x04000147 RID: 327
			TransactedMappingUnsupportedRemote,
			// Token: 0x04000148 RID: 328
			TxfMetadataAlreadyPresent,
			// Token: 0x04000149 RID: 329
			TransactionScopeCallbacksNotSet,
			// Token: 0x0400014A RID: 330
			TransactionRequiredPromotion,
			// Token: 0x0400014B RID: 331
			CannotExecuteFileInTransaction,
			// Token: 0x0400014C RID: 332
			TransactionsNotFrozen,
			// Token: 0x0400014D RID: 333
			MaximumNtStatus = 4294967295U
		}

		// Token: 0x02000005 RID: 5
		private class Informations
		{
			// Token: 0x02000006 RID: 6
			public enum PROCESSINFOCLASS
			{
				// Token: 0x0400014F RID: 335
				ProcessBasicInformation,
				// Token: 0x04000150 RID: 336
				ProcessQuotaLimits,
				// Token: 0x04000151 RID: 337
				ProcessIoCounters,
				// Token: 0x04000152 RID: 338
				ProcessVmCounters,
				// Token: 0x04000153 RID: 339
				ProcessTimes,
				// Token: 0x04000154 RID: 340
				ProcessBasePriority,
				// Token: 0x04000155 RID: 341
				ProcessRaisePriority,
				// Token: 0x04000156 RID: 342
				ProcessDebugPort,
				// Token: 0x04000157 RID: 343
				ProcessExceptionPort,
				// Token: 0x04000158 RID: 344
				ProcessAccessToken,
				// Token: 0x04000159 RID: 345
				ProcessLdtInformation,
				// Token: 0x0400015A RID: 346
				ProcessLdtSize,
				// Token: 0x0400015B RID: 347
				ProcessDefaultHardErrorMode,
				// Token: 0x0400015C RID: 348
				ProcessIoPortHandlers,
				// Token: 0x0400015D RID: 349
				ProcessPooledUsageAndLimits,
				// Token: 0x0400015E RID: 350
				ProcessWorkingSetWatch,
				// Token: 0x0400015F RID: 351
				ProcessUserModeIOPL,
				// Token: 0x04000160 RID: 352
				ProcessEnableAlignmentFaultFixup,
				// Token: 0x04000161 RID: 353
				ProcessPriorityClass,
				// Token: 0x04000162 RID: 354
				ProcessWx86Information,
				// Token: 0x04000163 RID: 355
				ProcessHandleCount,
				// Token: 0x04000164 RID: 356
				ProcessAffinityMask,
				// Token: 0x04000165 RID: 357
				ProcessPriorityBoost,
				// Token: 0x04000166 RID: 358
				ProcessDeviceMap,
				// Token: 0x04000167 RID: 359
				ProcessSessionInformation,
				// Token: 0x04000168 RID: 360
				ProcessForegroundInformation,
				// Token: 0x04000169 RID: 361
				ProcessWow64Information,
				// Token: 0x0400016A RID: 362
				ProcessImageFileName,
				// Token: 0x0400016B RID: 363
				ProcessLUIDDeviceMapsEnabled,
				// Token: 0x0400016C RID: 364
				ProcessBreakOnTermination,
				// Token: 0x0400016D RID: 365
				ProcessDebugObjectHandle,
				// Token: 0x0400016E RID: 366
				ProcessDebugFlags,
				// Token: 0x0400016F RID: 367
				ProcessHandleTracing,
				// Token: 0x04000170 RID: 368
				ProcessIoPriority,
				// Token: 0x04000171 RID: 369
				ProcessExecuteFlags,
				// Token: 0x04000172 RID: 370
				ProcessResourceManagement,
				// Token: 0x04000173 RID: 371
				ProcessCookie,
				// Token: 0x04000174 RID: 372
				ProcessImageInformation,
				// Token: 0x04000175 RID: 373
				ProcessCycleTime,
				// Token: 0x04000176 RID: 374
				ProcessPagePriority,
				// Token: 0x04000177 RID: 375
				ProcessInstrumentationCallback,
				// Token: 0x04000178 RID: 376
				ProcessThreadStackAllocation,
				// Token: 0x04000179 RID: 377
				ProcessWorkingSetWatchEx,
				// Token: 0x0400017A RID: 378
				ProcessImageFileNameWin32,
				// Token: 0x0400017B RID: 379
				ProcessImageFileMapping,
				// Token: 0x0400017C RID: 380
				ProcessAffinityUpdateMode,
				// Token: 0x0400017D RID: 381
				ProcessMemoryAllocationMode,
				// Token: 0x0400017E RID: 382
				ProcessGroupInformation,
				// Token: 0x0400017F RID: 383
				ProcessTokenVirtualizationEnabled,
				// Token: 0x04000180 RID: 384
				ProcessConsoleHostProcess,
				// Token: 0x04000181 RID: 385
				ProcessWindowInformation,
				// Token: 0x04000182 RID: 386
				ProcessHandleInformation,
				// Token: 0x04000183 RID: 387
				ProcessMitigationPolicy,
				// Token: 0x04000184 RID: 388
				ProcessDynamicFunctionTableInformation,
				// Token: 0x04000185 RID: 389
				ProcessHandleCheckingMode,
				// Token: 0x04000186 RID: 390
				ProcessKeepAliveCount,
				// Token: 0x04000187 RID: 391
				ProcessRevokeFileHandles,
				// Token: 0x04000188 RID: 392
				ProcessWorkingSetControl,
				// Token: 0x04000189 RID: 393
				ProcessHandleTable,
				// Token: 0x0400018A RID: 394
				ProcessCheckStackExtentsMode,
				// Token: 0x0400018B RID: 395
				ProcessCommandLineInformation,
				// Token: 0x0400018C RID: 396
				ProcessProtectionInformation,
				// Token: 0x0400018D RID: 397
				MaxProcessInfoClass
			}

			// Token: 0x02000007 RID: 7
			[Flags]
			public enum DebugObjectInformationClass
			{
				// Token: 0x0400018F RID: 399
				DebugObjectFlags = 1,
				// Token: 0x04000190 RID: 400
				MaxDebugObjectInfoClass = 2
			}

			// Token: 0x02000008 RID: 8
			public enum SYSTEM_INFORMATION_CLASS
			{
				// Token: 0x04000192 RID: 402
				SystemBasicInformation,
				// Token: 0x04000193 RID: 403
				SystemProcessorInformation,
				// Token: 0x04000194 RID: 404
				SystemPerformanceInformation,
				// Token: 0x04000195 RID: 405
				SystemTimeOfDayInformation,
				// Token: 0x04000196 RID: 406
				SystemPathInformation,
				// Token: 0x04000197 RID: 407
				SystemProcessInformation,
				// Token: 0x04000198 RID: 408
				SystemCallCountInformation,
				// Token: 0x04000199 RID: 409
				SystemDeviceInformation,
				// Token: 0x0400019A RID: 410
				SystemProcessorPerformanceInformation,
				// Token: 0x0400019B RID: 411
				SystemFlagsInformation,
				// Token: 0x0400019C RID: 412
				SystemCallTimeInformation,
				// Token: 0x0400019D RID: 413
				SystemModuleInformation,
				// Token: 0x0400019E RID: 414
				SystemLocksInformation,
				// Token: 0x0400019F RID: 415
				SystemStackTraceInformation,
				// Token: 0x040001A0 RID: 416
				SystemPagedPoolInformation,
				// Token: 0x040001A1 RID: 417
				SystemNonPagedPoolInformation,
				// Token: 0x040001A2 RID: 418
				SystemHandleInformation,
				// Token: 0x040001A3 RID: 419
				SystemObjectInformation,
				// Token: 0x040001A4 RID: 420
				SystemPageFileInformation,
				// Token: 0x040001A5 RID: 421
				SystemVdmInstemulInformation,
				// Token: 0x040001A6 RID: 422
				SystemVdmBopInformation,
				// Token: 0x040001A7 RID: 423
				SystemFileCacheInformation,
				// Token: 0x040001A8 RID: 424
				SystemPoolTagInformation,
				// Token: 0x040001A9 RID: 425
				SystemInterruptInformation,
				// Token: 0x040001AA RID: 426
				SystemDpcBehaviorInformation,
				// Token: 0x040001AB RID: 427
				SystemFullMemoryInformation,
				// Token: 0x040001AC RID: 428
				SystemLoadGdiDriverInformation,
				// Token: 0x040001AD RID: 429
				SystemUnloadGdiDriverInformation,
				// Token: 0x040001AE RID: 430
				SystemTimeAdjustmentInformation,
				// Token: 0x040001AF RID: 431
				SystemSummaryMemoryInformation,
				// Token: 0x040001B0 RID: 432
				SystemMirrorMemoryInformation,
				// Token: 0x040001B1 RID: 433
				SystemPerformanceTraceInformation,
				// Token: 0x040001B2 RID: 434
				SystemObsolete0,
				// Token: 0x040001B3 RID: 435
				SystemExceptionInformation,
				// Token: 0x040001B4 RID: 436
				SystemCrashDumpStateInformation,
				// Token: 0x040001B5 RID: 437
				SystemKernelDebuggerInformation,
				// Token: 0x040001B6 RID: 438
				SystemContextSwitchInformation,
				// Token: 0x040001B7 RID: 439
				SystemRegistryQuotaInformation,
				// Token: 0x040001B8 RID: 440
				SystemExtendServiceTableInformation,
				// Token: 0x040001B9 RID: 441
				SystemPrioritySeperation,
				// Token: 0x040001BA RID: 442
				SystemVerifierAddDriverInformation,
				// Token: 0x040001BB RID: 443
				SystemVerifierRemoveDriverInformation,
				// Token: 0x040001BC RID: 444
				SystemProcessorIdleInformation,
				// Token: 0x040001BD RID: 445
				SystemLegacyDriverInformation,
				// Token: 0x040001BE RID: 446
				SystemCurrentTimeZoneInformation,
				// Token: 0x040001BF RID: 447
				SystemLookasideInformation,
				// Token: 0x040001C0 RID: 448
				SystemTimeSlipNotification,
				// Token: 0x040001C1 RID: 449
				SystemSessionCreate,
				// Token: 0x040001C2 RID: 450
				SystemSessionDetach,
				// Token: 0x040001C3 RID: 451
				SystemSessionInformation,
				// Token: 0x040001C4 RID: 452
				SystemRangeStartInformation,
				// Token: 0x040001C5 RID: 453
				SystemVerifierInformation,
				// Token: 0x040001C6 RID: 454
				SystemVerifierThunkExtend,
				// Token: 0x040001C7 RID: 455
				SystemSessionProcessInformation,
				// Token: 0x040001C8 RID: 456
				SystemLoadGdiDriverInSystemSpace,
				// Token: 0x040001C9 RID: 457
				SystemNumaProcessorMap,
				// Token: 0x040001CA RID: 458
				SystemPrefetcherInformation,
				// Token: 0x040001CB RID: 459
				SystemExtendedProcessInformation,
				// Token: 0x040001CC RID: 460
				SystemRecommendedSharedDataAlignment,
				// Token: 0x040001CD RID: 461
				SystemComPlusPackage,
				// Token: 0x040001CE RID: 462
				SystemNumaAvailableMemory,
				// Token: 0x040001CF RID: 463
				SystemProcessorPowerInformation,
				// Token: 0x040001D0 RID: 464
				SystemEmulationBasicInformation,
				// Token: 0x040001D1 RID: 465
				SystemEmulationProcessorInformation,
				// Token: 0x040001D2 RID: 466
				SystemExtendedHandleInformation,
				// Token: 0x040001D3 RID: 467
				SystemLostDelayedWriteInformation,
				// Token: 0x040001D4 RID: 468
				SystemBigPoolInformation,
				// Token: 0x040001D5 RID: 469
				SystemSessionPoolTagInformation,
				// Token: 0x040001D6 RID: 470
				SystemSessionMappedViewInformation,
				// Token: 0x040001D7 RID: 471
				SystemHotpatchInformation,
				// Token: 0x040001D8 RID: 472
				SystemObjectSecurityMode,
				// Token: 0x040001D9 RID: 473
				SystemWatchdogTimerHandler,
				// Token: 0x040001DA RID: 474
				SystemWatchdogTimerInformation,
				// Token: 0x040001DB RID: 475
				SystemLogicalProcessorInformation,
				// Token: 0x040001DC RID: 476
				SystemWow64SharedInformationObsolete,
				// Token: 0x040001DD RID: 477
				SystemRegisterFirmwareTableInformationHandler,
				// Token: 0x040001DE RID: 478
				SystemFirmwareTableInformation,
				// Token: 0x040001DF RID: 479
				SystemModuleInformationEx,
				// Token: 0x040001E0 RID: 480
				SystemVerifierTriageInformation,
				// Token: 0x040001E1 RID: 481
				SystemSuperfetchInformation,
				// Token: 0x040001E2 RID: 482
				SystemMemoryListInformation,
				// Token: 0x040001E3 RID: 483
				SystemFileCacheInformationEx,
				// Token: 0x040001E4 RID: 484
				SystemThreadPriorityClientIdInformation,
				// Token: 0x040001E5 RID: 485
				SystemProcessorIdleCycleTimeInformation,
				// Token: 0x040001E6 RID: 486
				SystemVerifierCancellationInformation,
				// Token: 0x040001E7 RID: 487
				SystemProcessorPowerInformationEx,
				// Token: 0x040001E8 RID: 488
				SystemRefTraceInformation,
				// Token: 0x040001E9 RID: 489
				SystemSpecialPoolInformation,
				// Token: 0x040001EA RID: 490
				SystemProcessIdInformation,
				// Token: 0x040001EB RID: 491
				SystemErrorPortInformation,
				// Token: 0x040001EC RID: 492
				SystemBootEnvironmentInformation,
				// Token: 0x040001ED RID: 493
				SystemHypervisorInformation,
				// Token: 0x040001EE RID: 494
				SystemVerifierInformationEx,
				// Token: 0x040001EF RID: 495
				SystemTimeZoneInformation,
				// Token: 0x040001F0 RID: 496
				SystemImageFileExecutionOptionsInformation,
				// Token: 0x040001F1 RID: 497
				SystemCoverageInformation,
				// Token: 0x040001F2 RID: 498
				SystemPrefetchPatchInformation,
				// Token: 0x040001F3 RID: 499
				SystemVerifierFaultsInformation,
				// Token: 0x040001F4 RID: 500
				SystemSystemPartitionInformation,
				// Token: 0x040001F5 RID: 501
				SystemSystemDiskInformation,
				// Token: 0x040001F6 RID: 502
				SystemProcessorPerformanceDistribution,
				// Token: 0x040001F7 RID: 503
				SystemNumaProximityNodeInformation,
				// Token: 0x040001F8 RID: 504
				SystemDynamicTimeZoneInformation,
				// Token: 0x040001F9 RID: 505
				SystemCodeIntegrityInformation,
				// Token: 0x040001FA RID: 506
				SystemProcessorMicrocodeUpdateInformation,
				// Token: 0x040001FB RID: 507
				SystemProcessorBrandString,
				// Token: 0x040001FC RID: 508
				SystemVirtualAddressInformation,
				// Token: 0x040001FD RID: 509
				SystemLogicalProcessorAndGroupInformation,
				// Token: 0x040001FE RID: 510
				SystemProcessorCycleTimeInformation,
				// Token: 0x040001FF RID: 511
				SystemStoreInformation,
				// Token: 0x04000200 RID: 512
				SystemRegistryAppendString,
				// Token: 0x04000201 RID: 513
				SystemAitSamplingValue,
				// Token: 0x04000202 RID: 514
				SystemVhdBootInformation,
				// Token: 0x04000203 RID: 515
				SystemCpuQuotaInformation,
				// Token: 0x04000204 RID: 516
				SystemNativeBasicInformation,
				// Token: 0x04000205 RID: 517
				SystemSpare1,
				// Token: 0x04000206 RID: 518
				SystemLowPriorityIoInformation,
				// Token: 0x04000207 RID: 519
				SystemTpmBootEntropyInformation,
				// Token: 0x04000208 RID: 520
				SystemVerifierCountersInformation,
				// Token: 0x04000209 RID: 521
				SystemPagedPoolInformationEx,
				// Token: 0x0400020A RID: 522
				SystemSystemPtesInformationEx,
				// Token: 0x0400020B RID: 523
				SystemNodeDistanceInformation,
				// Token: 0x0400020C RID: 524
				SystemAcpiAuditInformation,
				// Token: 0x0400020D RID: 525
				SystemBasicPerformanceInformation,
				// Token: 0x0400020E RID: 526
				SystemQueryPerformanceCounterInformation,
				// Token: 0x0400020F RID: 527
				SystemSessionBigPoolInformation,
				// Token: 0x04000210 RID: 528
				SystemBootGraphicsInformation,
				// Token: 0x04000211 RID: 529
				SystemScrubPhysicalMemoryInformation,
				// Token: 0x04000212 RID: 530
				SystemBadPageInformation,
				// Token: 0x04000213 RID: 531
				SystemProcessorProfileControlArea,
				// Token: 0x04000214 RID: 532
				SystemCombinePhysicalMemoryInformation,
				// Token: 0x04000215 RID: 533
				SystemEntropyInterruptTimingCallback,
				// Token: 0x04000216 RID: 534
				SystemConsoleInformation,
				// Token: 0x04000217 RID: 535
				SystemPlatformBinaryInformation,
				// Token: 0x04000218 RID: 536
				SystemThrottleNotificationInformation,
				// Token: 0x04000219 RID: 537
				SystemHypervisorProcessorCountInformation,
				// Token: 0x0400021A RID: 538
				SystemDeviceDataInformation,
				// Token: 0x0400021B RID: 539
				SystemDeviceDataEnumerationInformation,
				// Token: 0x0400021C RID: 540
				SystemMemoryTopologyInformation,
				// Token: 0x0400021D RID: 541
				SystemMemoryChannelInformation,
				// Token: 0x0400021E RID: 542
				SystemBootLogoInformation,
				// Token: 0x0400021F RID: 543
				SystemProcessorPerformanceInformationEx,
				// Token: 0x04000220 RID: 544
				SystemSpare0,
				// Token: 0x04000221 RID: 545
				SystemSecureBootPolicyInformation,
				// Token: 0x04000222 RID: 546
				SystemPageFileInformationEx,
				// Token: 0x04000223 RID: 547
				SystemSecureBootInformation,
				// Token: 0x04000224 RID: 548
				SystemEntropyInterruptTimingRawInformation,
				// Token: 0x04000225 RID: 549
				SystemPortableWorkspaceEfiLauncherInformation,
				// Token: 0x04000226 RID: 550
				SystemFullProcessInformation,
				// Token: 0x04000227 RID: 551
				SystemKernelDebuggerInformationEx,
				// Token: 0x04000228 RID: 552
				SystemBootMetadataInformation,
				// Token: 0x04000229 RID: 553
				SystemSoftRebootInformation,
				// Token: 0x0400022A RID: 554
				SystemElamCertificateInformation,
				// Token: 0x0400022B RID: 555
				SystemOfflineDumpConfigInformation,
				// Token: 0x0400022C RID: 556
				SystemProcessorFeaturesInformation,
				// Token: 0x0400022D RID: 557
				SystemRegistryReconciliationInformation,
				// Token: 0x0400022E RID: 558
				SystemEdidInformation,
				// Token: 0x0400022F RID: 559
				MaxSystemInfoClass
			}

			// Token: 0x02000009 RID: 9
			public enum ThreadInformationClass
			{
				// Token: 0x04000231 RID: 561
				ThreadBasicInformation,
				// Token: 0x04000232 RID: 562
				ThreadTimes,
				// Token: 0x04000233 RID: 563
				ThreadPriority,
				// Token: 0x04000234 RID: 564
				ThreadBasePriority,
				// Token: 0x04000235 RID: 565
				ThreadAffinityMask,
				// Token: 0x04000236 RID: 566
				ThreadImpersonationToken,
				// Token: 0x04000237 RID: 567
				ThreadDescriptorTableEntry,
				// Token: 0x04000238 RID: 568
				ThreadEnableAlignmentFaultFixup,
				// Token: 0x04000239 RID: 569
				ThreadEventPair_Reusable,
				// Token: 0x0400023A RID: 570
				ThreadQuerySetWin32StartAddress,
				// Token: 0x0400023B RID: 571
				ThreadZeroTlsCell,
				// Token: 0x0400023C RID: 572
				ThreadPerformanceCount,
				// Token: 0x0400023D RID: 573
				ThreadAmILastThread,
				// Token: 0x0400023E RID: 574
				ThreadIdealProcessor,
				// Token: 0x0400023F RID: 575
				ThreadPriorityBoost,
				// Token: 0x04000240 RID: 576
				ThreadSetTlsArrayAddress,
				// Token: 0x04000241 RID: 577
				ThreadIsIoPending,
				// Token: 0x04000242 RID: 578
				ThreadHideFromDebugger,
				// Token: 0x04000243 RID: 579
				ThreadBreakOnTermination,
				// Token: 0x04000244 RID: 580
				ThreadSwitchLegacyState,
				// Token: 0x04000245 RID: 581
				ThreadIsTerminated,
				// Token: 0x04000246 RID: 582
				ThreadLastSystemCall,
				// Token: 0x04000247 RID: 583
				ThreadIoPriority,
				// Token: 0x04000248 RID: 584
				ThreadCycleTime,
				// Token: 0x04000249 RID: 585
				ThreadPagePriority,
				// Token: 0x0400024A RID: 586
				ThreadActualBasePriority,
				// Token: 0x0400024B RID: 587
				ThreadTebInformation,
				// Token: 0x0400024C RID: 588
				ThreadCSwitchMon,
				// Token: 0x0400024D RID: 589
				ThreadCSwitchPmu,
				// Token: 0x0400024E RID: 590
				ThreadWow64Context,
				// Token: 0x0400024F RID: 591
				ThreadGroupInformation,
				// Token: 0x04000250 RID: 592
				ThreadUmsInformation,
				// Token: 0x04000251 RID: 593
				ThreadCounterProfiling,
				// Token: 0x04000252 RID: 594
				ThreadIdealProcessorEx,
				// Token: 0x04000253 RID: 595
				ThreadCpuAccountingInformation,
				// Token: 0x04000254 RID: 596
				ThreadSuspendCount,
				// Token: 0x04000255 RID: 597
				ThreadDescription = 38,
				// Token: 0x04000256 RID: 598
				ThreadActualGroupAffinity = 41,
				// Token: 0x04000257 RID: 599
				ThreadDynamicCodePolicy
			}

			// Token: 0x0200000A RID: 10
			[Flags]
			public enum ThreadAccess
			{
				// Token: 0x04000259 RID: 601
				TERMINATE = 1,
				// Token: 0x0400025A RID: 602
				SUSPEND_RESUME = 2,
				// Token: 0x0400025B RID: 603
				GET_CONTEXT = 8,
				// Token: 0x0400025C RID: 604
				SET_CONTEXT = 16,
				// Token: 0x0400025D RID: 605
				SET_INFORMATION = 32,
				// Token: 0x0400025E RID: 606
				QUERY_INFORMATION = 64,
				// Token: 0x0400025F RID: 607
				SET_THREAD_TOKEN = 128,
				// Token: 0x04000260 RID: 608
				IMPERSONATE = 256,
				// Token: 0x04000261 RID: 609
				DIRECT_IMPERSONATION = 512
			}

			// Token: 0x0200000B RID: 11
			public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
			{
				// Token: 0x04000262 RID: 610
				[MarshalAs(UnmanagedType.U1)]
				public bool KernelDebuggerEnabled;

				// Token: 0x04000263 RID: 611
				[MarshalAs(UnmanagedType.U1)]
				public bool KernelDebuggerNotPresent;
			}
		}

		// Token: 0x0200000C RID: 12
		private class Processos
		{
			// Token: 0x06000009 RID: 9
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern bool QueryFullProcessImageName([In] IntPtr hProcess, [In] int dwFlags, [Out] StringBuilder lpExeName, ref int lpdwSize);

			// Token: 0x0600000A RID: 10
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr OpenProcess(DriveDaGitHub.Processos.ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

			// Token: 0x0600000B RID: 11 RVA: 0x00003760 File Offset: 0x00001960
			public static string GetProcessFilename(Process p)
			{
				int capacity = 2000;
				StringBuilder stringBuilder = new StringBuilder(capacity);
				if (!DriveDaGitHub.Processos.QueryFullProcessImageName(DriveDaGitHub.Processos.OpenProcess(DriveDaGitHub.Processos.ProcessAccessFlags.QueryLimitedInformation, false, p.Id), 0, stringBuilder, ref capacity))
				{
					return string.Empty;
				}
				return stringBuilder.ToString();
			}

			// Token: 0x0200000D RID: 13
			[Flags]
			private enum ProcessAccessFlags : uint
			{
				// Token: 0x04000265 RID: 613
				QueryLimitedInformation = 4096U
			}
		}

		// Token: 0x0200000E RID: 14
		private class Descriptografia
		{
			// Token: 0x0600000D RID: 13 RVA: 0x000037A4 File Offset: 0x000019A4
			public static string Descriptografar(string texto, string senha)
			{
				try
				{
					texto = texto.Replace(" ", "+");
					byte[] array = Convert.FromBase64String(texto);
					Aes aes = Aes.Create();
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(senha, DriveDaGitHub.Descriptografia.bytesParaUsar);
					aes.Key = rfc2898DeriveBytes.GetBytes(32);
					aes.IV = rfc2898DeriveBytes.GetBytes(16);
					MemoryStream memoryStream = new MemoryStream();
					CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.Close();
					texto = Encoding.Unicode.GetString(memoryStream.ToArray());
				}
				catch (Exception)
				{
				}
				return texto;
			}

			// Token: 0x04000266 RID: 614
			public static string ChaveDeDescriptografia = "GJAEO93J39G3J3GA063";

			// Token: 0x04000267 RID: 615
			private static byte[] bytesParaUsar = new byte[]
			{
				73,
				118,
				97,
				110,
				32,
				77,
				101,
				100,
				118,
				101,
				100,
				101,
				118
			};
		}

		// Token: 0x0200000F RID: 15
		private class TecnicasBasicas
		{
			// Token: 0x06000010 RID: 16 RVA: 0x00003844 File Offset: 0x00001A44
			public static void AntiProxy()
			{
				try
				{
					if (Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", false).GetValue("ProxyEnable").ToString() == "1")
					{
						DriveDaGitHub.SairDoPrograma("Proxy ativado! Por favor, pare a proxy e tente novamente.");
					}
				}
				catch (Exception)
				{
				}
			}

			// Token: 0x06000011 RID: 17 RVA: 0x0000389C File Offset: 0x00001A9C
			public static void MatarDepurador()
			{
				try
				{
					Random random = new Random();
					string tempPath = Path.GetTempPath();
					string str = "Zfdd";
					int i = random.Next(0, 5000);
					string text = tempPath + str + i.ToString() + ".bat";
					File.WriteAllText(text, "");
					Task.Delay(50).Wait();
					foreach (string str2 in DriveDaGitHub.TecnicasBasicas.Depuradores)
					{
						try
						{
							File.AppendAllText(text, "taskkill /f /pid \"" + str2 + ".exe\"" + Environment.NewLine);
						}
						catch (Exception)
						{
						}
					}
					File.AppendAllText(text, "del /f /q \"" + text + "\"" + Environment.NewLine);
					Process process = new Process();
					process.StartInfo.FileName = text;
					process.StartInfo.Arguments = "";
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.Start();
					process.WaitForExit();
					try
					{
						File.Delete(text);
					}
					catch (Exception)
					{
					}
				}
				catch (Exception)
				{
				}
			}

			// Token: 0x06000012 RID: 18 RVA: 0x000039B8 File Offset: 0x00001BB8
			public static void VerificarModificacaoDoArquivo()
			{
				try
				{
					if (File.GetLastWriteTime(DriveDaGitHub.local).ToString("dd/MM/yy") != DriveDaGitHub.diaDaCompilacao)
					{
						DriveDaGitHub.SairDoPrograma("Este arquivo foi modificado e não é original.");
					}
				}
				catch (Exception)
				{
					DriveDaGitHub.SairDoPrograma("Falha ao verificar a integridade do arquivo.");
				}
			}

			// Token: 0x06000013 RID: 19
			[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
			private static extern bool CheckRemoteDebuggerPresent(IntPtr Processo, ref bool Depurador);

			// Token: 0x06000014 RID: 20 RVA: 0x00003A14 File Offset: 0x00001C14
			public static void AntiDepurador()
			{
				bool flag = false;
				DriveDaGitHub.TecnicasBasicas.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag);
				if (flag || Debugger.IsAttached || Debugger.IsLogging())
				{
					DriveDaGitHub.SairDoPrograma("Depurador encontrado, saindo do programa...");
				}
			}

			// Token: 0x04000268 RID: 616
			private static readonly string[] Depuradores = new string[]
			{
				"x32dbg",
				"x64dbg",
				"OllyDbg",
				"ida",
				"ida64",
				"ida -",
				"ida64 -",
				"IMMUNITYDEBUGGER",
				"codecracker",
				"x96dbg",
				"de4dot",
				"ilspy",
				"graywolf",
				"die",
				"simpleassemblyexplorer",
				"megadumper",
				"x64netdumper",
				"hxd",
				"petools",
				"protection_id",
				"charles",
				"dnspy",
				"simpleassembly",
				"peek",
				"httpanalyzer",
				"httpdebug",
				"fiddler",
				"wireshark",
				"proxifier",
				"mitmproxy",
				"processhacker",
				"memoryedit",
				"memoryscanner",
				"memory scanner",
				"Nemesis",
				"KsDumperClient",
				"ExtremeDumper",
				"ExtremeDumper-x86",
				"THEMIDA_UNPACK_x86",
				"THEMIDA_UNPACK_x64",
				"pd"
			};
		}

		// Token: 0x02000010 RID: 16
		private class TecnicasAvancadas
		{
			// Token: 0x06000017 RID: 23 RVA: 0x00003BD4 File Offset: 0x00001DD4
			public static void ExecutarCodigoPorArquivo(string arquivo)
			{
				try
				{
					if (!File.Exists(arquivo))
					{
						DriveDaGitHub.SairDoPrograma("Arquivo de código não encontrado.");
					}
					string text = DriveDaGitHub.Descriptografia.Descriptografar(File.ReadAllText(arquivo), DriveDaGitHub.Descriptografia.ChaveDeDescriptografia);
					CompilerResults compilerResults = new CSharpCodeProvider().CompileAssemblyFromSource(new CompilerParameters
					{
						ReferencedAssemblies = 
						{
							"System.Drawing.dll",
							"System.IO.dll",
							"MetroFramework.dll",
							"MetroFramework.Design.dll",
							"MetroFramework.Fonts.dll",
							"Microsoft.CSharp.dll",
							"PresentationFramework.dll",
							"System.dll",
							"System.ComponentModel.Composition.dll",
							"System.Core.dll",
							"System.Data.dll",
							"System.Data.DataSetExtensions.dll"
						},
						GenerateInMemory = true,
						GenerateExecutable = true
					}, new string[]
					{
						text
					});
					if (compilerResults.Errors.HasErrors)
					{
						DriveDaGitHub.SairDoPrograma("Ocorreu um erro ao compilar o código do arquivo.");
					}
					compilerResults.CompiledAssembly.GetType("First.Program").GetMethod("Main").Invoke(null, null);
				}
				catch (Exception)
				{
					MessageBox.Show("Ocorreu um erro ao compilar o código do arquivo.", "Error");
					DriveDaGitHub.SairDoPrograma("Ocorreu um erro ao compilar o código do arquivo.");
				}
			}

			// Token: 0x06000018 RID: 24 RVA: 0x00003D6C File Offset: 0x00001F6C
			public static IEnumerable<Process> ProcessoFilhos(Process processo)
			{
				List<Process> list = new List<Process>();
				try
				{
					foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(string.Format("Select * From Win32_Process Where ParentProcessID={0}", processo.Id)).Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						list.Add(Process.GetProcessById(Convert.ToInt32(managementObject["ProcessID"])));
					}
				}
				catch (Exception)
				{
				}
				return list;
			}

			// Token: 0x06000019 RID: 25 RVA: 0x00003E04 File Offset: 0x00002004
			public static void IniciadoPeloExplorer()
			{
				bool flag = false;
				foreach (Process process in Process.GetProcessesByName("explorer"))
				{
					try
					{
						if (DriveDaGitHub.Processos.GetProcessFilename(process).ToLower() == "c:\\windows\\explorer.exe")
						{
							foreach (Process p in DriveDaGitHub.TecnicasAvancadas.ProcessoFilhos(process))
							{
								try
								{
									if (DriveDaGitHub.Processos.GetProcessFilename(p).ToLower() == DriveDaGitHub.local.ToLower())
									{
										flag = true;
										break;
									}
								}
								catch (Exception ex)
								{
									DriveDaGitHub.SairDoPrograma(ex.Message);
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
				if (!flag)
				{
					DriveDaGitHub.SairDoPrograma("Iniciado por um processo não confiávei, saindo...");
				}
			}

			// Token: 0x02000011 RID: 17
			public class Threads
			{
				// Token: 0x0600001B RID: 27
				[DllImport("ntdll.dll")]
				internal static extern DriveDaGitHub.NtStatus NtSetInformation(IntPtr ThreadHandle, DriveDaGitHub.Informations.ThreadInformationClass ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

				// Token: 0x0600001C RID: 28
				[DllImport("kernel32.dll")]
				private static extern IntPtr OpenThread(DriveDaGitHub.Informations.ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

				// Token: 0x0600001D RID: 29
				[DllImport("kernel32.dll")]
				private static extern uint SuspendThread(IntPtr tThread);

				// Token: 0x0600001E RID: 30
				[DllImport("kernel32.dll")]
				private static extern int ResumeThread(IntPtr tThread);

				// Token: 0x0600001F RID: 31
				[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
				private static extern bool CloseHandle(IntPtr handle);

				// Token: 0x06000020 RID: 32 RVA: 0x0000219E File Offset: 0x0000039E
				public static bool OcultarThreadDoDepurador(IntPtr alca)
				{
					return DriveDaGitHub.TecnicasAvancadas.Threads.NtSetInformation(alca, DriveDaGitHub.Informations.ThreadInformationClass.ThreadHideFromDebugger, IntPtr.Zero, 0) == DriveDaGitHub.NtStatus.Success;
				}

				// Token: 0x06000021 RID: 33 RVA: 0x00003EE8 File Offset: 0x000020E8
				public static void OcultarTodosOsThreads()
				{
					try
					{
						foreach (object obj in Process.GetCurrentProcess().Threads)
						{
							ProcessThread processThread = (ProcessThread)obj;
							try
							{
								IntPtr intPtr = DriveDaGitHub.TecnicasAvancadas.Threads.OpenThread(DriveDaGitHub.Informations.ThreadAccess.SET_INFORMATION, false, (uint)processThread.Id);
								if (!(intPtr == IntPtr.Zero))
								{
									DriveDaGitHub.TecnicasAvancadas.Threads.OcultarThreadDoDepurador(intPtr);
									DriveDaGitHub.TecnicasAvancadas.Threads.CloseHandle(intPtr);
								}
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}

			// Token: 0x02000012 RID: 18
			public class Kernel
			{
				// Token: 0x06000023 RID: 35
				[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
				internal static extern DriveDaGitHub.NtStatus NtQueryInformationProcess(IntPtr ProcessHandle, DriveDaGitHub.Informations.PROCESSINFOCLASS ProcessInformationClass, out IntPtr ProcessInformation, int ProcessInformationLength, out int ReturnLength);

				// Token: 0x06000024 RID: 36
				[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
				internal static extern DriveDaGitHub.NtStatus NtClose(IntPtr Handle);

				// Token: 0x06000025 RID: 37
				[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
				internal static extern DriveDaGitHub.NtStatus NtRemoveProcessDebug(IntPtr ProcessHandle, IntPtr DebugObjectHandle);

				// Token: 0x06000026 RID: 38
				[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
				internal static extern DriveDaGitHub.NtStatus NtSetInformationDebugObject(IntPtr DebugObjectHandle, DriveDaGitHub.Informations.DebugObjectInformationClass DebugObjectInformationClass, IntPtr DebugObjectInformation, int DebugObjectInformationLength, [Optional] out int ReturnLength);

				// Token: 0x06000027 RID: 39
				[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
				internal static extern DriveDaGitHub.NtStatus NtQuerySystemInformation(DriveDaGitHub.Informations.SYSTEM_INFORMATION_CLASS SystemInformationClass, IntPtr SystemInformation, int SystemInformationLength, [Optional] out int ReturnLength);

				// Token: 0x06000028 RID: 40 RVA: 0x00003F8C File Offset: 0x0000218C
				private static bool VerificarPortaDeDepuracao()
				{
					IntPtr intPtr = new IntPtr(0);
					int num;
					return DriveDaGitHub.TecnicasAvancadas.Kernel.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, DriveDaGitHub.Informations.PROCESSINFOCLASS.ProcessDebugPort, out intPtr, Marshal.SizeOf<IntPtr>(intPtr), out num) == DriveDaGitHub.NtStatus.Success && intPtr == new IntPtr(-1);
				}

				// Token: 0x06000029 RID: 41 RVA: 0x00003FD0 File Offset: 0x000021D0
				private unsafe static bool DesanexarDeAlgumProcesso()
				{
					IntPtr invalid_HANDLE_VALUE = DriveDaGitHub.TecnicasAvancadas.Kernel.INVALID_HANDLE_VALUE;
					uint structure = 0U;
					int num;
					int num2;
					return DriveDaGitHub.TecnicasAvancadas.Kernel.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, DriveDaGitHub.Informations.PROCESSINFOCLASS.ProcessDebugPort, out invalid_HANDLE_VALUE, IntPtr.Size, out num) == DriveDaGitHub.NtStatus.Success && DriveDaGitHub.TecnicasAvancadas.Kernel.NtSetInformationDebugObject(invalid_HANDLE_VALUE, DriveDaGitHub.Informations.DebugObjectInformationClass.DebugObjectFlags, new IntPtr((void*)(&structure)), Marshal.SizeOf<uint>(structure), out num2) == DriveDaGitHub.NtStatus.Success && DriveDaGitHub.TecnicasAvancadas.Kernel.NtRemoveProcessDebug(Process.GetCurrentProcess().Handle, invalid_HANDLE_VALUE) == DriveDaGitHub.NtStatus.Success && DriveDaGitHub.TecnicasAvancadas.Kernel.NtClose(invalid_HANDLE_VALUE) == DriveDaGitHub.NtStatus.Success;
				}

				// Token: 0x0600002A RID: 42 RVA: 0x0000403C File Offset: 0x0000223C
				private unsafe static bool VerificarInformacoesDeDebugDoKernel()
				{
					DriveDaGitHub.Informations.SYSTEM_KERNEL_DEBUGGER_INFORMATION system_KERNEL_DEBUGGER_INFORMATION;
					int num;
					return DriveDaGitHub.TecnicasAvancadas.Kernel.NtQuerySystemInformation(DriveDaGitHub.Informations.SYSTEM_INFORMATION_CLASS.SystemKernelDebuggerInformation, new IntPtr((void*)(&system_KERNEL_DEBUGGER_INFORMATION)), Marshal.SizeOf<DriveDaGitHub.Informations.SYSTEM_KERNEL_DEBUGGER_INFORMATION>(system_KERNEL_DEBUGGER_INFORMATION), out num) == DriveDaGitHub.NtStatus.Success && system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerEnabled && !system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerNotPresent;
				}

				// Token: 0x0600002B RID: 43 RVA: 0x000021B3 File Offset: 0x000003B3
				public static void AntiDebugger()
				{
					if (DriveDaGitHub.TecnicasAvancadas.Kernel.VerificarPortaDeDepuracao())
					{
						DriveDaGitHub.SairDoPrograma("Uma porta de depuração foi encontrada no kernel.");
					}
					if (DriveDaGitHub.TecnicasAvancadas.Kernel.DesanexarDeAlgumProcesso())
					{
						DriveDaGitHub.SairDoPrograma("Um depurador foi encontrado em um processo.");
					}
					if (DriveDaGitHub.TecnicasAvancadas.Kernel.VerificarInformacoesDeDebugDoKernel())
					{
						DriveDaGitHub.SairDoPrograma("Um depurador kernel-mode foi encontrado.");
					}
				}

				// Token: 0x04000269 RID: 617
				private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
			}

			// Token: 0x02000013 RID: 19
			public class Memoria
			{
				// Token: 0x0600002E RID: 46
				[DllImport("kernel32.dll")]
				private unsafe static extern bool VirtualProtect(byte* lpAddress, int dwSize, uint flNewProtect, out uint lpflOldProtect);

				// Token: 0x0600002F RID: 47 RVA: 0x00004078 File Offset: 0x00002278
				internal unsafe static void IniciarProtecaoVirtual()
				{
					Module module = typeof(DriveDaGitHub).Module;
					byte* ptr = (byte*)((void*)Marshal.GetHINSTANCE(module));
					byte* ptr2 = ptr + 60;
					ptr2 = ptr + *(uint*)ptr2;
					ptr2 += 6;
					ushort num = *(ushort*)ptr2;
					ptr2 += 14;
					ushort num2 = *(ushort*)ptr2;
					ptr2 = ptr2 + 4 + num2;
					byte* ptr3 = stackalloc byte[(UIntPtr)11];
					uint num3;
					if (module.FullyQualifiedName[0] != '<')
					{
						byte* ptr4 = ptr + *(uint*)(ptr2 - 16);
						if (*(uint*)(ptr2 - 120) != 0U)
						{
							byte* ptr5 = ptr + *(uint*)(ptr2 - 120);
							byte* ptr6 = ptr + *(uint*)ptr5;
							byte* ptr7 = ptr + *(uint*)(ptr5 + 12);
							byte* ptr8 = ptr + *(uint*)ptr6 + 2;
							DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr7, 11, 64U, out num3);
							*(int*)ptr3 = 1818522734;
							*(int*)(ptr3 + 4) = 1818504812;
							*(short*)(ptr3 + (IntPtr)4 * 2) = 108;
							ptr3[10] = 0;
							for (int i = 0; i < 11; i++)
							{
								ptr7[i] = ptr3[i];
							}
							DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr8, 11, 64U, out num3);
							*(int*)ptr3 = 1866691662;
							*(int*)(ptr3 + 4) = 1852404846;
							*(short*)(ptr3 + (IntPtr)4 * 2) = 25973;
							ptr3[10] = 0;
							for (int j = 0; j < 11; j++)
							{
								ptr8[j] = ptr3[j];
							}
						}
						for (int k = 0; k < (int)num; k++)
						{
							DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr2, 8, 64U, out num3);
							Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
							ptr2 += 40;
						}
						DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr4, 72, 64U, out num3);
						byte* ptr9 = ptr + *(uint*)(ptr4 + 8);
						*(int*)ptr4 = 0;
						*(int*)(ptr4 + 4) = 0;
						*(int*)(ptr4 + (IntPtr)2 * 4) = 0;
						*(int*)(ptr4 + (IntPtr)3 * 4) = 0;
						DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr9, 4, 64U, out num3);
						*(int*)ptr9 = 0;
						ptr9 += 12;
						ptr9 += *(uint*)ptr9;
						ptr9 = (ptr9 + 7L & -4L);
						ptr9 += 2;
						ushort num4 = (ushort)(*ptr9);
						ptr9 += 2;
						for (int l = 0; l < (int)num4; l++)
						{
							DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr9, 8, 64U, out num3);
							ptr9 += 4;
							ptr9 += 4;
							for (int m = 0; m < 8; m++)
							{
								DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr9, 4, 64U, out num3);
								*ptr9 = 0;
								ptr9++;
								if (*ptr9 == 0)
								{
									ptr9 += 3;
									break;
								}
								*ptr9 = 0;
								ptr9++;
								if (*ptr9 == 0)
								{
									ptr9 += 2;
									break;
								}
								*ptr9 = 0;
								ptr9++;
								if (*ptr9 == 0)
								{
									ptr9++;
									break;
								}
								*ptr9 = 0;
								ptr9++;
							}
						}
						return;
					}
					uint num5 = *(uint*)(ptr2 - 16);
					uint num6 = *(uint*)(ptr2 - 120);
					uint[] array = new uint[(int)num];
					uint[] array2 = new uint[(int)num];
					uint[] array3 = new uint[(int)num];
					for (int n = 0; n < (int)num; n++)
					{
						DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr2, 8, 64U, out num3);
						Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
						array[n] = *(uint*)(ptr2 + 12);
						array2[n] = *(uint*)(ptr2 + 8);
						array3[n] = *(uint*)(ptr2 + 20);
						ptr2 += 40;
					}
					if (num6 != 0U)
					{
						for (int num7 = 0; num7 < (int)num; num7++)
						{
							if (array[num7] <= num6 && num6 < array[num7] + array2[num7])
							{
								num6 = num6 - array[num7] + array3[num7];
								break;
							}
						}
						byte* ptr10 = ptr + num6;
						uint num8 = *(uint*)ptr10;
						for (int num9 = 0; num9 < (int)num; num9++)
						{
							if (array[num9] <= num8 && num8 < array[num9] + array2[num9])
							{
								num8 = num8 - array[num9] + array3[num9];
								break;
							}
						}
						byte* ptr11 = ptr + num8;
						uint num10 = *(uint*)(ptr10 + 12);
						for (int num11 = 0; num11 < (int)num; num11++)
						{
							if (array[num11] <= num10 && num10 < array[num11] + array2[num11])
							{
								num10 = num10 - array[num11] + array3[num11];
								break;
							}
						}
						uint num12 = *(uint*)ptr11 + 2U;
						for (int num13 = 0; num13 < (int)num; num13++)
						{
							if (array[num13] <= num12 && num12 < array[num13] + array2[num13])
							{
								num12 = num12 - array[num13] + array3[num13];
								break;
							}
						}
						DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr + num10, 11, 64U, out num3);
						*(int*)ptr3 = 1818522734;
						*(int*)(ptr3 + 4) = 1818504812;
						*(short*)(ptr3 + (IntPtr)4 * 2) = 108;
						ptr3[10] = 0;
						for (int num14 = 0; num14 < 11; num14++)
						{
							(ptr + num10)[num14] = ptr3[num14];
						}
						DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr + num12, 11, 64U, out num3);
						*(int*)ptr3 = 1866691662;
						*(int*)(ptr3 + 4) = 1852404846;
						*(short*)(ptr3 + (IntPtr)4 * 2) = 25973;
						ptr3[10] = 0;
						for (int num15 = 0; num15 < 11; num15++)
						{
							(ptr + num12)[num15] = ptr3[num15];
						}
					}
					for (int num16 = 0; num16 < (int)num; num16++)
					{
						if (array[num16] <= num5 && num5 < array[num16] + array2[num16])
						{
							num5 = num5 - array[num16] + array3[num16];
							break;
						}
					}
					byte* ptr12 = ptr + num5;
					DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr12, 72, 64U, out num3);
					uint num17 = *(uint*)(ptr12 + 8);
					for (int num18 = 0; num18 < (int)num; num18++)
					{
						if (array[num18] <= num17 && num17 < array[num18] + array2[num18])
						{
							num17 = num17 - array[num18] + array3[num18];
							break;
						}
					}
					*(int*)ptr12 = 0;
					*(int*)(ptr12 + 4) = 0;
					*(int*)(ptr12 + (IntPtr)2 * 4) = 0;
					*(int*)(ptr12 + (IntPtr)3 * 4) = 0;
					byte* ptr13 = ptr + num17;
					DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr13, 4, 64U, out num3);
					*(int*)ptr13 = 0;
					ptr13 += 12;
					ptr13 += *(uint*)ptr13;
					ptr13 = (ptr13 + 7L & -4L);
					ptr13 += 2;
					ushort num19 = (ushort)(*ptr13);
					ptr13 += 2;
					for (int num20 = 0; num20 < (int)num19; num20++)
					{
						DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr13, 8, 64U, out num3);
						ptr13 += 4;
						ptr13 += 4;
						for (int num21 = 0; num21 < 8; num21++)
						{
							DriveDaGitHub.TecnicasAvancadas.Memoria.VirtualProtect(ptr13, 4, 64U, out num3);
							*ptr13 = 0;
							ptr13++;
							if (*ptr13 == 0)
							{
								ptr13 += 3;
								break;
							}
							*ptr13 = 0;
							ptr13++;
							if (*ptr13 == 0)
							{
								ptr13 += 2;
								break;
							}
							*ptr13 = 0;
							ptr13++;
							if (*ptr13 == 0)
							{
								ptr13++;
								break;
							}
							*ptr13 = 0;
							ptr13++;
						}
					}
				}
			}

			// Token: 0x02000014 RID: 20
			public class AutoDepuracao
			{
				// Token: 0x06000031 RID: 49
				[DllImport("kernel32.dll", SetLastError = true)]
				private static extern bool DebugActiveProcess(int dwProcessId);

				// Token: 0x06000032 RID: 50
				[DllImport("Kernel32.dll", SetLastError = true)]
				private static extern bool WaitForDebugEvent(out DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.DebugEvent lpDebugEvent, int dwMilliseconds);

				// Token: 0x06000033 RID: 51
				[DllImport("Kernel32.dll", SetLastError = true)]
				private static extern bool ContinueDebugEvent(int dwProcessId, int dwThreadId, int dwContinueStatus);

				// Token: 0x06000034 RID: 52
				[DllImport("Kernel32.dll", SetLastError = true)]
				public static extern bool IsDebuggerPresent();

				// Token: 0x06000035 RID: 53 RVA: 0x000021F5 File Offset: 0x000003F5
				private static void SairQuandoFechar(object processo)
				{
					Thread.CurrentThread.IsBackground = true;
					((Process)processo).WaitForExit();
					Environment.Exit(0);
					DriveDaGitHub.SairDoPrograma("Não foi possível se auto-fechar");
				}

				// Token: 0x06000036 RID: 54 RVA: 0x000046C8 File Offset: 0x000028C8
				private static void EsperarPeloDepurador()
				{
					DateTime now = DateTime.Now;
					while (!DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.IsDebuggerPresent())
					{
						double totalMinutes = (DateTime.Now - now).TotalMinutes;
						Thread.Sleep(1);
					}
				}

				// Token: 0x06000037 RID: 55 RVA: 0x0000221D File Offset: 0x0000041D
				public static void VerificarPid(int pid)
				{
					if (DriveDaGitHub.Processos.GetProcessFilename(Process.GetProcessById(pid)).ToLower() != DriveDaGitHub.local.ToLower())
					{
						DriveDaGitHub.SairDoPrograma("O processo foi modificado");
					}
				}

				// Token: 0x06000038 RID: 56 RVA: 0x00004708 File Offset: 0x00002908
				private static void DebuggerThread(object arg)
				{
					Thread.CurrentThread.IsBackground = true;
					DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.DebugEvent debugEvent = default(DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.DebugEvent);
					debugEvent.bytes = new byte[1024];
					if (!DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.DebugActiveProcess((int)arg))
					{
						DriveDaGitHub.SairDoPrograma("Um depurador foi detectado no processo ativo.");
					}
					for (;;)
					{
						if (!DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.WaitForDebugEvent(out debugEvent, -1))
						{
							DriveDaGitHub.SairDoPrograma("Não foi possível continuar o processo de auto-debug.");
						}
						int dwContinueStatus = 65538;
						if (debugEvent.dwDebugEventCode == DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.DebugEventType.EXCEPTION_DEBUG_EVENT)
						{
							dwContinueStatus = -2147418111;
						}
						DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.ContinueDebugEvent(debugEvent.dwProcessId, debugEvent.dwThreadId, dwContinueStatus);
					}
				}

				// Token: 0x06000039 RID: 57 RVA: 0x00004790 File Offset: 0x00002990
				public static void AutoDepurar(int pid)
				{
					try
					{
						if (pid != 0)
						{
							Process processById = Process.GetProcessById(pid);
							new Thread(new ParameterizedThreadStart(DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.SairQuandoFechar))
							{
								IsBackground = true
							}.Start(processById);
							DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.EsperarPeloDepurador();
							DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.DebuggerThread(pid);
							Environment.Exit(1);
						}
						Process currentProcess = Process.GetCurrentProcess();
						Process process = Process.Start(new ProcessStartInfo(Environment.GetCommandLineArgs()[0], currentProcess.Id.ToString())
						{
							UseShellExecute = false,
							CreateNoWindow = false,
							ErrorDialog = false
						});
						if (process == null)
						{
							throw new ApplicationException("Unable to debug");
						}
						new Thread(new ParameterizedThreadStart(DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.SairQuandoFechar))
						{
							IsBackground = true
						}.Start(process);
						new Thread(new ParameterizedThreadStart(DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.DebuggerThread))
						{
							IsBackground = true
						}.Start(process.Id);
						DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.EsperarPeloDepurador();
					}
					catch (Exception)
					{
						DriveDaGitHub.SairDoPrograma("Não foi possível continuar o auto-debug.");
					}
				}

				// Token: 0x0400026A RID: 618
				private const int DBG_CONTINUE = 65538;

				// Token: 0x0400026B RID: 619
				private const int DBG_EXCEPTION_NOT_HANDLED = -2147418111;

				// Token: 0x02000015 RID: 21
				private enum DebugEventType
				{
					// Token: 0x0400026D RID: 621
					CREATE_PROCESS_DEBUG_EVENT = 3,
					// Token: 0x0400026E RID: 622
					CREATE_THREAD_DEBUG_EVENT = 2,
					// Token: 0x0400026F RID: 623
					EXCEPTION_DEBUG_EVENT = 1,
					// Token: 0x04000270 RID: 624
					EXIT_PROCESS_DEBUG_EVENT = 5,
					// Token: 0x04000271 RID: 625
					EXIT_THREAD_DEBUG_EVENT = 4,
					// Token: 0x04000272 RID: 626
					LOAD_DLL_DEBUG_EVENT = 6,
					// Token: 0x04000273 RID: 627
					OUTPUT_DEBUG_STRING_EVENT = 8,
					// Token: 0x04000274 RID: 628
					RIP_EVENT,
					// Token: 0x04000275 RID: 629
					UNLOAD_DLL_DEBUG_EVENT = 7
				}

				// Token: 0x02000016 RID: 22
				private struct DebugEvent
				{
					// Token: 0x04000276 RID: 630
					[MarshalAs(UnmanagedType.I4)]
					public DriveDaGitHub.TecnicasAvancadas.AutoDepuracao.DebugEventType dwDebugEventCode;

					// Token: 0x04000277 RID: 631
					public int dwProcessId;

					// Token: 0x04000278 RID: 632
					public int dwThreadId;

					// Token: 0x04000279 RID: 633
					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
					public byte[] bytes;
				}
			}
		}
	}
}
