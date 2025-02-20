using System.Collections;
using System.Text.RegularExpressions;

namespace PracticaDeExamen
{
    public partial class Form1 : Form
    {
        int i = 0;
        ArrayList registros = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = NOM.Text;
            string curp = CURP.Text;
            dgv.Rows.Add();
            dgv.Rows[i].Cells[0].Value = nombre;
            dgv.Rows[i].Cells[1].Value = edadYestado(curp)[1];
            dgv.Rows[i].Cells[2].Value = edadYestado(curp)[0];

            string[] registro = { dgv.Rows[i].Cells[0].ToString(), dgv.Rows[i].Cells[1].ToString(), dgv.Rows[i].Cells[2].ToString() };
            registros.Add(registro[0]);
            registros.Add(registro[1]);
            registros.Add(registro[2]);

            NOM.Clear();
            CURP.Clear();
            i++;
        }
        public string[] edadYestado(string curp)
        {
            string[] res = new string[2];
            string expresion = "^[A-Z]{4}\\d{6}[HM]{1}[A-Z]{2}[A-Z]{3}[0-9A-Z]{2}$";
            if (Regex.IsMatch(curp, expresion) == true)
            {
                //ESTADO y fecha de nacimiento
                string year = curp[4].ToString() + curp[5].ToString();
                string mes = curp[6].ToString() + curp[7].ToString();
                string dia = curp[8].ToString() + curp[9].ToString();

                string estado = curp[11].ToString() + curp[12].ToString();
                DateTime fechaNac = DateTime.Parse(dia + "/" + mes + "/" + year);
                switch (estado)
                {
                    case "AG": estado = "Aguascalientes"; break;
                    case "BC": estado = "Baja California"; break;
                    case "BS": estado = "Baja California Sur"; break;
                    case "CC": estado = "Campeche"; break;
                    case "CS": estado = "Chiapas"; break;
                    case "CH": estado = "Chihuahua"; break;
                    case "CM": estado = "Coahuila"; break;
                    case "DG": estado = "Durango"; break;
                    case "GT": estado = "Guanajuato"; break;
                    case "GR": estado = "Guerrero"; break;
                    case "HG": estado = "Hidalgo"; break;
                    case "JC": estado = "Jalisco"; break;
                    case "MC": estado = "M�xico"; break;
                    case "MN": estado = "Michoac�n"; break;
                    case "MS": estado = "Morelos"; break;
                    case "NT": estado = "Nayarit"; break;
                    case "NL": estado = "Nuevo Le�n"; break;
                    case "OC": estado = "Oaxaca"; break;
                    case "PL": estado = "Puebla"; break;
                    case "QT": estado = "Quer�taro"; break;
                    case "QR": estado = "Quintana Roo"; break;
                    case "SP": estado = "San Luis Potos�"; break;
                    case "SL": estado = "Sinaloa"; break;
                    case "SR": estado = "Sonora"; break;
                    case "TC": estado = "Tabasco"; break;
                    case "TS": estado = "Tamaulipas"; break;
                    case "TL": estado = "Tlaxcala"; break;
                    case "VZ": estado = "Veracruz"; break;
                    case "YN": estado = "Yucat�n"; break;
                    case "ZS": estado = "Zacatecas"; break;
                    default: estado = "Abreviatura no reconocida"; break;
                }
                res[0] = estado;

                //EDAD
                DateTime hoy = DateTime.Today;
                TimeSpan edadHoras = hoy.Date - fechaNac.Date;
                DateTime edad = new DateTime() + edadHoras;

                if (hoy.Month < fechaNac.Month)
                {
                    res[1]=((edad.Year - 1) + " a�os - " + (edad.Month - 1) + " meses - " + edad.Day + " dias");
                }
                else
                {
                    res[1] = (edad.Year + " a�os - " + edad.Month + " meses - " + edad.Day + " dias");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una CURP valida");
            }
            return res;
        }
    }
}
