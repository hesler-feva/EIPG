using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Datos_usuarios.cache;

namespace Proyecto_EIPG
{
    public partial class Reporte_Alumnos : Form
    {

        public Reporte_Alumnos()
        {
            InitializeComponent();
            Txt_NoIdentidad_Alum.Focus();

        }
        //varible que se asignaran a las variables publicas del otro formulario que las necesite
        public int i, valor;
        String id_alumno, primer_nombre_alu, segundo_nombre_alu, primer_apellido_alu, segundo_apellido_alu, estado_salud,id_pariente,primer_nombre_pariente,segundo_nombre_pariente,primer_apellido_pariente,segundo_apellido_pariente,correo_pariente,telefono_pariente,direccion_pariente, genero_alumno, estado_alumno, grado, id_genero_pariente;
        DateTime fecha_nac, fecha_nac_paeinte;

        //boton alumno grado llama al formulario para listar los alumnos solo por el grado
        private void btn_alum_grado_Click(object sender, EventArgs e)
        {
            Reporteria_Alumnos_Grados repor_alum = new Reporteria_Alumnos_Grados();
            this.Close();
            repor_alum.Show();
        }

        //radio buton para indicar si se desea listar los alumnos activos 
        private void Rdbn_A_activos_CheckedChanged(object sender, EventArgs e)
        {
            string estado = " ";

            if (Rdbn_A_activos.Checked == true)
                estado = "1";


            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            dataGridView1.DataSource = proc.Reporte_alumno_por_estado(estado);
        }

        //radio buton para indicar si se desea listar los alumnos activos 
        private void Rdbn_A_inactivos_CheckedChanged(object sender, EventArgs e)
        {
            string estado = " ";

            if (Rdbn_A_inactivos.Checked == true)
                estado = "2";


            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            dataGridView1.DataSource = proc.Reporte_alumno_por_estado(estado);

        }

        //radio buton para indicar que desea listar los morosos
        private void rdbn_morosos_CheckedChanged(object sender, EventArgs e)
        {
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            dataGridView1.DataSource = proc.listar_Alumno_Morosos();
        }

        //boton refrescar en caso que ya se realizo una busqueda y se desea volver a listar todos los alumnos
        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            Reporte_Alumnos ra = new Reporte_Alumnos();
            this.Hide();
            ra.Show();

        }

        //validacion del texbox con codigo ASCII donde no se permiten espacion puede ingresar numeros o guiones
        private void txt_NoIdentidad_Alum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 44) || (e.KeyChar >= 46 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Ingrese solo Letras o numeros, no se permiten espacios");
                e.Handled = true;
            }
        }

        //boton regresar cierra este formulario
        private void btn_regresar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        int   Cantidad_hijo=0;
        decimal Saldo_alu = 0;
        //boton buscar 
        private void btnBuscar_Alum_Click(object sender, EventArgs e)
        {
            if (Txt_NoIdentidad_Alum.Text.Trim().Equals(""))//primero valida que el texbox no este vacio en caso afirmativo muestra el mensaje
            {
                error.SetError(Txt_NoIdentidad_Alum, "Introduzca los datos correctamente");
                Txt_NoIdentidad_Alum.Focus();
            }
            else
            {
                //si el texbox esta lleno
                error.Clear();//borra las advertencias
                Rdbn_Morosos.Checked = false;
                //envia los datos al procedimiento almacenado para listar a los alumnos
                Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
                dataGridView1.DataSource = proc.Buscar_Alumno(Txt_NoIdentidad_Alum.Text);
                Txt_NoIdentidad_Alum.Clear();
                Txt_NoIdentidad_Alum.Focus();
                MessageBox.Show("Para modificar de doble click sobre el empleado que desea modificar");
            }

            
        }

        private void pnlReporte_Alum_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //boton regresar cierra este formulario
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu_Admin ma = new Menu_Admin();
            ma.Show();
            this.Close();
        }

        private void btnModificar_alumno_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
           
        }
        //evento load del formulario 
        private void Reporte_Alumnos_Load(object sender, EventArgs e)
        {
            //carga los labels con los datos de los usuarios
            Lbl_Nombre_admin.Text = cache_usuario.Usuario;
            Lbl_Identidad_Admin.Text = cache_usuario.Id;
            Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
            dataGridView1.DataSource = proc.listar_Alumno();
            Txt_NoIdentidad_Alum.Clear();
            Txt_NoIdentidad_Alum.Focus();
     

        }

        //boton generar reporte, genera el reporte con los datos presentados en el datagrid
        private void btnGenerar_Reporte_Click(object sender, EventArgs e)
        {
            ReporteriaAlumnoAct readc = new ReporteriaAlumnoAct();
            if (Rdbn_A_activos.Checked==false && Rdbn_A_inactivos.Checked==false)
            {
                ReporteriaAlumnos ra = new ReporteriaAlumnos();
                ra.ShowDialog();
            }

            if (Rdbn_A_activos.Checked == true)
            {

                readc.parametro = 1;
                readc.ShowDialog();

            }

                if (Rdbn_A_inactivos.Checked == true)
                {
                    readc.parametro = 2;
                    readc.ShowDialog();
                }

        }

  

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
        }



        private void txt_EstadoSalud_Alum_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        //validacion en caso que el usuario presione el boton de cerrar formulario por error
        private void Reporte_Alumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                 Menu_Admin ma = new Menu_Admin();
            ma.Show();
            }
        }

        private void txt_NoIdentidad_Alum_Validated(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //funcion para capturar los datos de la fila presionada al hacer clic
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            i = e.RowIndex;
            if (i != -1)
            {
                //asigna los valores de cada celda a las variables declaradas al inicio de esta clase
                id_alumno = dataGridView1.Rows[i].Cells[0].Value.ToString();
                primer_nombre_alu = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value.ToString());
                segundo_nombre_alu = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value.ToString());
                primer_apellido_alu = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value.ToString());
                segundo_apellido_alu = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value.ToString());
                fecha_nac = Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value.ToString());
                estado_salud = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value.ToString());
                genero_alumno = dataGridView1.Rows[i].Cells[7].Value.ToString();
                estado_alumno = dataGridView1.Rows[i].Cells[8].Value.ToString();
               // id_nivel_academico = Convert.ToInt32(dataGridView1.Rows[i].Cells[9].Value);
                grado = dataGridView1.Rows[i].Cells[10].Value.ToString();
                id_pariente = Convert.ToString(dataGridView1.Rows[i].Cells[11].Value.ToString());
                primer_nombre_pariente = Convert.ToString(dataGridView1.Rows[i].Cells[12].Value.ToString());
                segundo_nombre_pariente = Convert.ToString(dataGridView1.Rows[i].Cells[13].Value.ToString());
                primer_apellido_pariente = Convert.ToString(dataGridView1.Rows[i].Cells[14].Value.ToString());
                segundo_apellido_pariente = Convert.ToString(dataGridView1.Rows[i].Cells[15].Value.ToString());
                fecha_nac_paeinte = Convert.ToDateTime(dataGridView1.Rows[i].Cells[16].Value.ToString());
                correo_pariente = Convert.ToString(dataGridView1.Rows[i].Cells[17].Value.ToString());
                telefono_pariente = Convert.ToString(dataGridView1.Rows[i].Cells[18].Value.ToString());
                direccion_pariente = Convert.ToString(dataGridView1.Rows[i].Cells[19].Value.ToString());
                id_genero_pariente = dataGridView1.Rows[i].Cells[20].Value.ToString();
                Cantidad_hijo = Convert.ToInt32(dataGridView1.Rows[i].Cells[21].Value.ToString());
                Saldo_alu = Convert.ToDecimal(dataGridView1.Rows[i].Cells[22].Value.ToString());

                if (reportes.Reporte_alumno==1)//si la opcion es actualizar alumno asigna los datos al formulario de alumnos
                {
                    Ingresar_Alumno iA = new Ingresar_Alumno();
                    iA.Cmb_Estado_Alumno_.Enabled = true;
                    iA.Lbl_Estado_Alumno.Enabled = true;
                    iA.Mask_NoIdentidad_Alum.Text = id_alumno;
                    iA.Txt_PrimerNombre_Alum.Text = primer_nombre_alu;
                    iA.Txt_SegundoNombre_Alum.Text = segundo_nombre_alu;
                    iA.Txt_Primer_Apelldo_Alum.Text = primer_apellido_alu;
                    iA.Txt_SegundoApellido_Alum.Text = segundo_apellido_alu;
                    iA.Dtp_Fecha_Nacimiento_Alum.Value = fecha_nac;
                    iA.Mask_No_Identidad_padre.Text = id_pariente;
                    iA.Txt_EstadoSalud_Alum.Text = estado_salud;
                    iA.Cmb_Genero_Alu = genero_alumno;
                    iA.Cmb_Estado_Alumno = estado_alumno;
                    iA.Cmb_Grado_Alu = grado;
                    iA.Txt_Primer_Nombre_Padre.Text = primer_nombre_pariente;
                    iA.Txt_Segundo_Nombre_Padre.Text = segundo_nombre_pariente;
                    iA.Txt_Primer_Apellido_Padre.Text = primer_apellido_pariente;
                    iA.Txt_Segundo_Apellido_Padre.Text = segundo_apellido_pariente;
                    iA.Txt_Correo_Padre.Text = correo_pariente;
                    iA.Mask_NumeroMovil_Padre.Text = telefono_pariente;
                    iA.Txt_Direccion_Padre.Text = direccion_pariente;
                    iA.Cmb_Genero_Pariente = id_genero_pariente;

                    iA.Btn_Guardar.Enabled = false;
                    iA.Btn_Actualizar.Enabled = true;
                    iA.Seleccion=1;
                    this.Hide();
                    iA.ShowDialog();
                }
                else //si la funcion es pagar matricula manda los datos al formulario de pagar  matricula
                {
                    Ingresos_Matricula_Mensualidad imm = new Ingresos_Matricula_Mensualidad();
                    imm.Txt_ID_estudiante.Text = id_alumno;
                    imm.Txt_Nombre_Estudiante.Text = primer_nombre_alu +" " +segundo_nombre_alu+ " " + primer_apellido_alu + " " + segundo_apellido_alu;
                    imm.Txt_Grado_Estudiante.Text = grado;
                    imm.Txt_ID_Padre.Text = id_pariente;
                    imm.Txt_Nombre_Padre.Text = primer_nombre_pariente +" " + segundo_nombre_pariente +" " + primer_apellido_pariente + " "+ segundo_apellido_pariente;
                    imm.Txt_Direccion_padre.Text = direccion_pariente;
                    imm.Txt_Saldo_Estudiante.Text = Saldo_alu.ToString();
                    imm.Show();
                    this.Hide();
                }


                
            }
 
        }
    }
    }
