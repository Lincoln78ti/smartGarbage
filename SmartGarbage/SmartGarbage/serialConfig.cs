using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarbage
{
    class serialConfig {
        public int Serial(string port_Name, int baud_Rate) {
            // Configurando porta serial
            string portName = port_Name;    // Mudar aqui
            int baudRate = baud_Rate;       // padrao 9600
            SerialPort serialPort = new SerialPort(portName, baudRate);

            // Leitura da serial/bluetooth...
            try{
                if (!serialPort.IsOpen) {
                    serialPort.Open();
                }      
            } catch (Exception ex) {
                Console.WriteLine("Erro na porta serial: " + portName);
            }

            string scanSerial = "";


            try {
                Console.WriteLine("Teste: ");
                if (serialPort.IsOpen) {
                    scanSerial = serialPort.ReadExisting();
                }
                serialPort.Write("");
                serialPort.Close();
                return Convert.ToInt32(scanSerial);
            }
            catch (Exception ex) {
                return 0;
            }
        }
    }
}
