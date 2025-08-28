namespace EDAT_JD2025_P01
{
    public partial class frmNumerosAleatorios : Form
    {
        public frmNumerosAleatorios()
        {
            InitializeComponent();
        }

        private void btnMostrarMensage_Click(object sender, EventArgs e)
        {

            // Instancia de la clase Random para generar valores aleatorios
            Random random = new Random();

            // Creación de un objeto Empleado
            Empleado empleado = new Empleado();

            // Asignación de valores aleatorios a las propiedades
            empleado.Numero = random.Next(1000, 9999);
            empleado.Nombre = "Empleado " + random.Next(1, 100);

            // Generar una fecha de nacimiento aleatoria
            DateTime start = new DateTime(1950, 1, 1);
            int range = (DateTime.Today - start).Days;
            empleado.FechaNacimiento = start.AddDays(random.Next(range));

            // Asignar un sexo aleatorio
            empleado.Sexo = (random.Next(2) == 0) ? "Masculino" : "Femenino";

            // Asignar un grupo aleatorio
            char[] grupos = { 'A', 'B', 'C', 'D' };
            empleado.Grupo = grupos[random.Next(grupos.Length)];

            // Asignar un sueldo aleatorio
            empleado.Sueldo = random.Next(15000, 50000) * 1.0;

            // Asignar un valor booleano aleatorio para el seguro médico
            empleado.SeguroMedico = random.Next(2) == 1;

            // Mostrar los datos en la interfaz de usuario
            txtNumero.Text = empleado.Numero.ToString();
            txtNombre.Text = empleado.Nombre;
            dtpFechaNacimiento.Value = empleado.FechaNacimiento;

            // Asignar el sexo a los radio buttons
            if (empleado.Sexo == "Masculino")
            {
                rbMasculino.Checked = true;
            }
            else
            {
                rbFemenino.Checked = true;
            }

            // Asignar el grupo al ComboBox
            cbGrupo.Text = empleado.Grupo.ToString();

            txtSueldo.Text = empleado.Sueldo.ToString("N2"); // Formato con 2 decimales
            chkSeguroMedico.Checked = empleado.SeguroMedico;
        }

        
    }

    public class Empleado
    {
        // Atributos privados
        private int _intNumero;
        private string _strNombre;
        private DateTime _dtmFechaNacimiento;
        private string _strSexo;
        private char _chrGrupo;
        private double _dblSueldo;
        private bool _blnSeguroMedico;

        // Propiedades públicas con get y set
        public int Numero
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        }

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }

        public string Sexo
        {
            get { return _strSexo; }
            set { _strSexo = value; }
        }

        public char Grupo
        {
            get { return _chrGrupo; }
            set { _chrGrupo = value; }
        }

        public double Sueldo
        {
            get { return _dblSueldo; }
            set { _dblSueldo = value; }
        }

        public bool SeguroMedico
        {
            get { return _blnSeguroMedico; }
            set { _blnSeguroMedico = value; }
        }

        // Método ToString() para devolver una representación en texto del objeto
        public override string ToString()
        {
            return $"Número: {Numero}, Nombre: {Nombre}, Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}, " +
                   $"Sexo: {Sexo}, Grupo: {Grupo}, Sueldo: {Sueldo:C}, Seguro Médico: {(SeguroMedico ? "Sí" : "No")}";
        }
    }
}
