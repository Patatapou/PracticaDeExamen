using System.Collections;
using System.Text.RegularExpressions;
using Microsoft.Win32;

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
            Registro registro = new Registro(nombre, edadYestado(curp)[1], edadYestado(curp)[0]);

            dgv.Rows[i].Cells[0].Value = registro.GetNombre();
            dgv.Rows[i].Cells[1].Value = registro.GetEdad();
            dgv.Rows[i].Cells[2].Value = registro.GetEstado();

            registros.Add(registro);

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
                    case "CL": estado = "Coahuila"; break;
                    case "DG": estado = "Durango"; break;
                    case "GT": estado = "Guanajuato"; break;
                    case "GR": estado = "Guerrero"; break;
                    case "HG": estado = "Hidalgo"; break;
                    case "JC": estado = "Jalisco"; break;
                    case "MC": estado = "México"; break;
                    case "MN": estado = "Michoacán"; break;
                    case "MS": estado = "Morelos"; break;
                    case "NT": estado = "Nayarit"; break;
                    case "NL": estado = "Nuevo León"; break;
                    case "OC": estado = "Oaxaca"; break;
                    case "PL": estado = "Puebla"; break;
                    case "QT": estado = "Querétaro"; break;
                    case "QR": estado = "Quintana Roo"; break;
                    case "SP": estado = "San Luis Potosí"; break;
                    case "SL": estado = "Sinaloa"; break;
                    case "SR": estado = "Sonora"; break;
                    case "TC": estado = "Tabasco"; break;
                    case "TS": estado = "Tamaulipas"; break;
                    case "TL": estado = "Tlaxcala"; break;
                    case "VZ": estado = "Veracruz"; break;
                    case "YN": estado = "Yucatán"; break;
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
                    res[1] = ((edad.Year - 1) + " años - " + (edad.Month - 1) + " meses - " + edad.Day + " dias");
                }
                else
                {
                    res[1] = (edad.Year + " años - " + edad.Month + " meses - " + edad.Day + " dias");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una CURP valida");
            }
            return res;
        }

        private void BUSCADOR_TextChanged(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            if (BUSCADOR.Text=="")
            {
                int a = 0;
                for (int i = 0; i < registros.Count; i++) 
                {
                    dgv.Rows.Add();
                }
                foreach (Registro x in registros)
                {
                    dgv.Rows[a].Cells[0].Value = x.GetNombre();
                    dgv.Rows[a].Cells[1].Value = x.GetEdad();
                    dgv.Rows[a].Cells[2].Value = x.GetEstado();
                    a++;
                }
            }
            else
            {
                dgv.Rows.Add();
                foreach (Registro x in registros)
                {
                    if (x.GetNombre() == BUSCADOR.Text)
                    {
                        dgv.Rows[0].Cells[0].Value = x.GetNombre();
                        dgv.Rows[0].Cells[1].Value = x.GetEdad();
                        dgv.Rows[0].Cells[2].Value = x.GetEstado();
                        break;
                    }
                }
            }
        }
    }
}
