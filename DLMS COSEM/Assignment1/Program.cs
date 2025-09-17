using System;
using System.Collections.Generic;   

namespace DLMS_PROJ1
{
        class Program
        {
            static void Main(string[] args)
            {
                // OBIS code for Active Energy Import (1-0:1.8.0.255)
                var obis_code = new ObisCode(1, 0, 1, 8, 0, 255);

                // Class ID for Register object is 3
                ushort class_Id = 3;
                byte Attribute_Id = 2; // e.g., value attribute

                byte[] apdu = GetRequestApdu.CreateGetRequest(obis_code, class_Id, Attribute_Id);

                Console.WriteLine("OBIS Code: " + obis_code);
                Console.WriteLine("GET Request APDU: " + BitConverter.ToString(apdu));
            }
        }
}
