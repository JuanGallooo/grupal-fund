namespace Principal.Interfaz
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listMiembrosT = new System.Windows.Forms.ListView();
            this.CedulaT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeudaT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infoDineroPrestamo = new System.Windows.Forms.Label();
            this.infoTotalMiembros = new System.Windows.Forms.Label();
            this.infoRendimiento = new System.Windows.Forms.Label();
            this.infoValorAporte = new System.Windows.Forms.Label();
            this.infoDisponible = new System.Windows.Forms.Label();
            this.infoGanancias = new System.Windows.Forms.Label();
            this.infoAportes = new System.Windows.Forms.Label();
            this.lbnDineroPrestado = new System.Windows.Forms.Label();
            this.lbnTotalMiembros = new System.Windows.Forms.Label();
            this.lbnRindeInfo = new System.Windows.Forms.Label();
            this.lbnInfoValor = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAporteInfo = new System.Windows.Forms.Label();
            this.imagenAporte = new System.Windows.Forms.Label();
            this.btnEliminarT = new System.Windows.Forms.Button();
            this.btnAgregarT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalcularPagoM = new System.Windows.Forms.Button();
            this.infoReferencia = new System.Windows.Forms.Label();
            this.infoDireccion = new System.Windows.Forms.Label();
            this.infoCorreo = new System.Windows.Forms.Label();
            this.infoTelefono = new System.Windows.Forms.Label();
            this.lbnReferencia = new System.Windows.Forms.Label();
            this.lbnDirec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infoAportesTotales = new System.Windows.Forms.Label();
            this.infoFecha = new System.Windows.Forms.Label();
            this.infoCedula = new System.Windows.Forms.Label();
            this.infoNombre = new System.Windows.Forms.Label();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.btnCuota = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labAporte = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.labAportes = new System.Windows.Forms.Label();
            this.labFecha = new System.Windows.Forms.Label();
            this.labCedula = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.btnReporteMiembro = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listMiembros = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aportes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deuda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporteGeneral = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCerrrar = new System.Windows.Forms.Button();
            this.btnCalcularPagosF = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.infoNombreFondo = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnModificarMiembro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 492);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.listMiembrosT);
            this.panel3.Controls.Add(this.infoDineroPrestamo);
            this.panel3.Controls.Add(this.infoTotalMiembros);
            this.panel3.Controls.Add(this.infoRendimiento);
            this.panel3.Controls.Add(this.infoValorAporte);
            this.panel3.Controls.Add(this.infoDisponible);
            this.panel3.Controls.Add(this.infoGanancias);
            this.panel3.Controls.Add(this.infoAportes);
            this.panel3.Controls.Add(this.lbnDineroPrestado);
            this.panel3.Controls.Add(this.lbnTotalMiembros);
            this.panel3.Controls.Add(this.lbnRindeInfo);
            this.panel3.Controls.Add(this.lbnInfoValor);
            this.panel3.Controls.Add(this.labelMonto);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbAporteInfo);
            this.panel3.Controls.Add(this.imagenAporte);
            this.panel3.Controls.Add(this.btnEliminarT);
            this.panel3.Controls.Add(this.btnAgregarT);
            this.panel3.Location = new System.Drawing.Point(403, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 483);
            this.panel3.TabIndex = 3;
            // 
            // listMiembrosT
            // 
            this.listMiembrosT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CedulaT,
            this.NombreT,
            this.DeudaT});
            this.listMiembrosT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMiembrosT.Location = new System.Drawing.Point(4, 4);
            this.listMiembrosT.Name = "listMiembrosT";
            this.listMiembrosT.Size = new System.Drawing.Size(313, 133);
            this.listMiembrosT.TabIndex = 17;
            this.listMiembrosT.UseCompatibleStateImageBehavior = false;
            this.listMiembrosT.View = System.Windows.Forms.View.Details;
            this.listMiembrosT.SelectedIndexChanged += new System.EventHandler(this.listMiembrosT_SelectedIndexChanged);
            // 
            // CedulaT
            // 
            this.CedulaT.Text = "Cedula";
            this.CedulaT.Width = 92;
            // 
            // NombreT
            // 
            this.NombreT.Text = "Nombre";
            this.NombreT.Width = 105;
            // 
            // DeudaT
            // 
            this.DeudaT.Text = "Deuda";
            this.DeudaT.Width = 90;
            // 
            // infoDineroPrestamo
            // 
            this.infoDineroPrestamo.AutoSize = true;
            this.infoDineroPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDineroPrestamo.Location = new System.Drawing.Point(189, 457);
            this.infoDineroPrestamo.Name = "infoDineroPrestamo";
            this.infoDineroPrestamo.Size = new System.Drawing.Size(16, 16);
            this.infoDineroPrestamo.TabIndex = 16;
            this.infoDineroPrestamo.Text = "--";
            // 
            // infoTotalMiembros
            // 
            this.infoTotalMiembros.AutoSize = true;
            this.infoTotalMiembros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTotalMiembros.Location = new System.Drawing.Point(189, 432);
            this.infoTotalMiembros.Name = "infoTotalMiembros";
            this.infoTotalMiembros.Size = new System.Drawing.Size(16, 16);
            this.infoTotalMiembros.TabIndex = 15;
            this.infoTotalMiembros.Text = "--";
            // 
            // infoRendimiento
            // 
            this.infoRendimiento.AutoSize = true;
            this.infoRendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoRendimiento.Location = new System.Drawing.Point(189, 403);
            this.infoRendimiento.Name = "infoRendimiento";
            this.infoRendimiento.Size = new System.Drawing.Size(16, 16);
            this.infoRendimiento.TabIndex = 14;
            this.infoRendimiento.Text = "--";
            // 
            // infoValorAporte
            // 
            this.infoValorAporte.AutoSize = true;
            this.infoValorAporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoValorAporte.Location = new System.Drawing.Point(189, 374);
            this.infoValorAporte.Name = "infoValorAporte";
            this.infoValorAporte.Size = new System.Drawing.Size(16, 16);
            this.infoValorAporte.TabIndex = 13;
            this.infoValorAporte.Text = "--";
            // 
            // infoDisponible
            // 
            this.infoDisponible.AutoSize = true;
            this.infoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDisponible.Location = new System.Drawing.Point(189, 350);
            this.infoDisponible.Name = "infoDisponible";
            this.infoDisponible.Size = new System.Drawing.Size(16, 16);
            this.infoDisponible.TabIndex = 12;
            this.infoDisponible.Text = "--";
            // 
            // infoGanancias
            // 
            this.infoGanancias.AutoSize = true;
            this.infoGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGanancias.Location = new System.Drawing.Point(189, 304);
            this.infoGanancias.Name = "infoGanancias";
            this.infoGanancias.Size = new System.Drawing.Size(16, 16);
            this.infoGanancias.TabIndex = 12;
            this.infoGanancias.Text = "--";
            this.infoGanancias.Click += new System.EventHandler(this.label2_Click);
            // 
            // infoAportes
            // 
            this.infoAportes.AutoSize = true;
            this.infoAportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoAportes.Location = new System.Drawing.Point(189, 325);
            this.infoAportes.Name = "infoAportes";
            this.infoAportes.Size = new System.Drawing.Size(16, 16);
            this.infoAportes.TabIndex = 12;
            this.infoAportes.Text = "--";
            // 
            // lbnDineroPrestado
            // 
            this.lbnDineroPrestado.AutoSize = true;
            this.lbnDineroPrestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnDineroPrestado.Location = new System.Drawing.Point(7, 457);
            this.lbnDineroPrestado.Name = "lbnDineroPrestado";
            this.lbnDineroPrestado.Size = new System.Drawing.Size(132, 16);
            this.lbnDineroPrestado.TabIndex = 11;
            this.lbnDineroPrestado.Text = "Dinero en prestamo :";
            // 
            // lbnTotalMiembros
            // 
            this.lbnTotalMiembros.AutoSize = true;
            this.lbnTotalMiembros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTotalMiembros.Location = new System.Drawing.Point(7, 432);
            this.lbnTotalMiembros.Name = "lbnTotalMiembros";
            this.lbnTotalMiembros.Size = new System.Drawing.Size(127, 16);
            this.lbnTotalMiembros.TabIndex = 10;
            this.lbnTotalMiembros.Text = "Total de miembros :";
            // 
            // lbnRindeInfo
            // 
            this.lbnRindeInfo.AutoSize = true;
            this.lbnRindeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnRindeInfo.Location = new System.Drawing.Point(7, 403);
            this.lbnRindeInfo.Name = "lbnRindeInfo";
            this.lbnRindeInfo.Size = new System.Drawing.Size(138, 16);
            this.lbnRindeInfo.TabIndex = 9;
            this.lbnRindeInfo.Text = "Valor de rendimiento :";
            // 
            // lbnInfoValor
            // 
            this.lbnInfoValor.AutoSize = true;
            this.lbnInfoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnInfoValor.Location = new System.Drawing.Point(7, 374);
            this.lbnInfoValor.Name = "lbnInfoValor";
            this.lbnInfoValor.Size = new System.Drawing.Size(107, 16);
            this.lbnInfoValor.TabIndex = 8;
            this.lbnInfoValor.Text = "Valor de aporte :";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(7, 350);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(173, 16);
            this.labelMonto.TabIndex = 7;
            this.labelMonto.Text = "Total aportes en el fondo $: ";
            this.labelMonto.Click += new System.EventHandler(this.labelMonto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ganancias :";
            // 
            // lbAporteInfo
            // 
            this.lbAporteInfo.AutoSize = true;
            this.lbAporteInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAporteInfo.Location = new System.Drawing.Point(7, 325);
            this.lbAporteInfo.Name = "lbAporteInfo";
            this.lbAporteInfo.Size = new System.Drawing.Size(130, 16);
            this.lbAporteInfo.TabIndex = 7;
            this.lbAporteInfo.Text = "Aportes en el fondo :";
            // 
            // imagenAporte
            // 
            this.imagenAporte.AutoSize = true;
            this.imagenAporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagenAporte.Location = new System.Drawing.Point(7, 198);
            this.imagenAporte.Name = "imagenAporte";
            this.imagenAporte.Size = new System.Drawing.Size(96, 16);
            this.imagenAporte.TabIndex = 6;
            this.imagenAporte.Text = "imagen Aporte";
            // 
            // btnEliminarT
            // 
            this.btnEliminarT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarT.Location = new System.Drawing.Point(179, 143);
            this.btnEliminarT.Name = "btnEliminarT";
            this.btnEliminarT.Size = new System.Drawing.Size(135, 25);
            this.btnEliminarT.TabIndex = 5;
            this.btnEliminarT.Text = "Eliminar Miembro T";
            this.btnEliminarT.UseVisualStyleBackColor = true;
            this.btnEliminarT.Click += new System.EventHandler(this.btnEliminarT_Click);
            // 
            // btnAgregarT
            // 
            this.btnAgregarT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarT.Location = new System.Drawing.Point(10, 143);
            this.btnAgregarT.Name = "btnAgregarT";
            this.btnAgregarT.Size = new System.Drawing.Size(150, 25);
            this.btnAgregarT.TabIndex = 4;
            this.btnAgregarT.Text = "Agregar Miembro T";
            this.btnAgregarT.UseVisualStyleBackColor = true;
            this.btnAgregarT.Click += new System.EventHandler(this.btnAgregarT_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnModificarMiembro);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnCalcularPagoM);
            this.panel2.Controls.Add(this.infoReferencia);
            this.panel2.Controls.Add(this.infoDireccion);
            this.panel2.Controls.Add(this.infoCorreo);
            this.panel2.Controls.Add(this.infoTelefono);
            this.panel2.Controls.Add(this.lbnReferencia);
            this.panel2.Controls.Add(this.lbnDirec);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.infoAportesTotales);
            this.panel2.Controls.Add(this.infoFecha);
            this.panel2.Controls.Add(this.infoCedula);
            this.panel2.Controls.Add(this.infoNombre);
            this.panel2.Controls.Add(this.btnAbonar);
            this.panel2.Controls.Add(this.btnCuota);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.labAporte);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnPrestar);
            this.panel2.Controls.Add(this.labAportes);
            this.panel2.Controls.Add(this.labFecha);
            this.panel2.Controls.Add(this.labCedula);
            this.panel2.Controls.Add(this.labNombre);
            this.panel2.Controls.Add(this.btnReporteMiembro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(724, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 492);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalcularPagoM
            // 
            this.btnCalcularPagoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPagoM.Location = new System.Drawing.Point(69, 431);
            this.btnCalcularPagoM.Name = "btnCalcularPagoM";
            this.btnCalcularPagoM.Size = new System.Drawing.Size(138, 25);
            this.btnCalcularPagoM.TabIndex = 21;
            this.btnCalcularPagoM.Text = "Calcular Pago M";
            this.btnCalcularPagoM.UseVisualStyleBackColor = true;
            this.btnCalcularPagoM.Click += new System.EventHandler(this.btnCalcularPagoM_Click);
            // 
            // infoReferencia
            // 
            this.infoReferencia.AutoSize = true;
            this.infoReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoReferencia.Location = new System.Drawing.Point(137, 258);
            this.infoReferencia.Name = "infoReferencia";
            this.infoReferencia.Size = new System.Drawing.Size(16, 16);
            this.infoReferencia.TabIndex = 20;
            this.infoReferencia.Text = "--";
            // 
            // infoDireccion
            // 
            this.infoDireccion.AutoSize = true;
            this.infoDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDireccion.Location = new System.Drawing.Point(137, 236);
            this.infoDireccion.Name = "infoDireccion";
            this.infoDireccion.Size = new System.Drawing.Size(16, 16);
            this.infoDireccion.TabIndex = 20;
            this.infoDireccion.Text = "--";
            // 
            // infoCorreo
            // 
            this.infoCorreo.AutoSize = true;
            this.infoCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCorreo.Location = new System.Drawing.Point(137, 214);
            this.infoCorreo.Name = "infoCorreo";
            this.infoCorreo.Size = new System.Drawing.Size(16, 16);
            this.infoCorreo.TabIndex = 20;
            this.infoCorreo.Text = "--";
            // 
            // infoTelefono
            // 
            this.infoTelefono.AutoSize = true;
            this.infoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTelefono.Location = new System.Drawing.Point(137, 192);
            this.infoTelefono.Name = "infoTelefono";
            this.infoTelefono.Size = new System.Drawing.Size(16, 16);
            this.infoTelefono.TabIndex = 19;
            this.infoTelefono.Text = "--";
            // 
            // lbnReferencia
            // 
            this.lbnReferencia.AutoSize = true;
            this.lbnReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnReferencia.Location = new System.Drawing.Point(16, 258);
            this.lbnReferencia.Name = "lbnReferencia";
            this.lbnReferencia.Size = new System.Drawing.Size(80, 16);
            this.lbnReferencia.TabIndex = 18;
            this.lbnReferencia.Text = "Referencia :";
            // 
            // lbnDirec
            // 
            this.lbnDirec.AutoSize = true;
            this.lbnDirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnDirec.Location = new System.Drawing.Point(16, 236);
            this.lbnDirec.Name = "lbnDirec";
            this.lbnDirec.Size = new System.Drawing.Size(71, 16);
            this.lbnDirec.TabIndex = 18;
            this.lbnDirec.Text = "Dirección :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Correo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Teléfono :";
            // 
            // infoAportesTotales
            // 
            this.infoAportesTotales.AutoSize = true;
            this.infoAportesTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoAportesTotales.Location = new System.Drawing.Point(137, 169);
            this.infoAportesTotales.Name = "infoAportesTotales";
            this.infoAportesTotales.Size = new System.Drawing.Size(16, 16);
            this.infoAportesTotales.TabIndex = 16;
            this.infoAportesTotales.Text = "--";
            // 
            // infoFecha
            // 
            this.infoFecha.AutoSize = true;
            this.infoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFecha.Location = new System.Drawing.Point(137, 150);
            this.infoFecha.Name = "infoFecha";
            this.infoFecha.Size = new System.Drawing.Size(16, 16);
            this.infoFecha.TabIndex = 15;
            this.infoFecha.Text = "--";
            // 
            // infoCedula
            // 
            this.infoCedula.AutoSize = true;
            this.infoCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCedula.Location = new System.Drawing.Point(137, 128);
            this.infoCedula.Name = "infoCedula";
            this.infoCedula.Size = new System.Drawing.Size(16, 16);
            this.infoCedula.TabIndex = 14;
            this.infoCedula.Text = "--";
            // 
            // infoNombre
            // 
            this.infoNombre.AutoSize = true;
            this.infoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoNombre.Location = new System.Drawing.Point(137, 106);
            this.infoNombre.Name = "infoNombre";
            this.infoNombre.Size = new System.Drawing.Size(16, 16);
            this.infoNombre.TabIndex = 13;
            this.infoNombre.Text = "--";
            // 
            // btnAbonar
            // 
            this.btnAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonar.Location = new System.Drawing.Point(69, 402);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(138, 25);
            this.btnAbonar.TabIndex = 12;
            this.btnAbonar.Text = "Abonar Deuda";
            this.btnAbonar.UseVisualStyleBackColor = true;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // btnCuota
            // 
            this.btnCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuota.Location = new System.Drawing.Point(69, 373);
            this.btnCuota.Name = "btnCuota";
            this.btnCuota.Size = new System.Drawing.Size(138, 25);
            this.btnCuota.TabIndex = 11;
            this.btnCuota.Text = "Pagar Cuota";
            this.btnCuota.UseVisualStyleBackColor = true;
            this.btnCuota.Click += new System.EventHandler(this.btnCuota_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(134, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 20);
            this.button2.TabIndex = 10;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labAporte
            // 
            this.labAporte.AutoSize = true;
            this.labAporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAporte.Location = new System.Drawing.Point(16, 288);
            this.labAporte.Name = "labAporte";
            this.labAporte.Size = new System.Drawing.Size(119, 16);
            this.labAporte.TabIndex = 9;
            this.labAporte.Text = "Modificar Aportes :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrestar
            // 
            this.btnPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestar.Location = new System.Drawing.Point(69, 344);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(138, 25);
            this.btnPrestar.TabIndex = 6;
            this.btnPrestar.Text = "Realizar Prestamo";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // labAportes
            // 
            this.labAportes.AutoSize = true;
            this.labAportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAportes.Location = new System.Drawing.Point(16, 169);
            this.labAportes.Name = "labAportes";
            this.labAportes.Size = new System.Drawing.Size(110, 16);
            this.labAportes.TabIndex = 5;
            this.labAportes.Text = "Aportes Totales :";
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha.Location = new System.Drawing.Point(16, 150);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(100, 16);
            this.labFecha.TabIndex = 4;
            this.labFecha.Text = "Fecha Ingreso :";
            // 
            // labCedula
            // 
            this.labCedula.AutoSize = true;
            this.labCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCedula.Location = new System.Drawing.Point(16, 128);
            this.labCedula.Name = "labCedula";
            this.labCedula.Size = new System.Drawing.Size(57, 16);
            this.labCedula.TabIndex = 3;
            this.labCedula.Text = "Cédula :";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(16, 106);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(63, 16);
            this.labNombre.TabIndex = 2;
            this.labNombre.Text = "Nombre :";
            // 
            // btnReporteMiembro
            // 
            this.btnReporteMiembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteMiembro.Location = new System.Drawing.Point(69, 315);
            this.btnReporteMiembro.Name = "btnReporteMiembro";
            this.btnReporteMiembro.Size = new System.Drawing.Size(138, 25);
            this.btnReporteMiembro.TabIndex = 1;
            this.btnReporteMiembro.Text = "Reporte Miembro";
            this.btnReporteMiembro.UseVisualStyleBackColor = true;
            this.btnReporteMiembro.Click += new System.EventHandler(this.btnReporteMiembro_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.listMiembros);
            this.flowLayoutPanel1.Controls.Add(this.btnAgregar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(401, 492);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // listMiembros
            // 
            this.listMiembros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.Cedula,
            this.Nombre,
            this.Aportes,
            this.Deuda});
            this.listMiembros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewItem1.StateImageIndex = 0;
            this.listMiembros.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listMiembros.Location = new System.Drawing.Point(3, 3);
            this.listMiembros.Name = "listMiembros";
            this.listMiembros.Size = new System.Drawing.Size(394, 445);
            this.listMiembros.TabIndex = 4;
            this.listMiembros.UseCompatibleStateImageBehavior = false;
            this.listMiembros.View = System.Windows.Forms.View.Details;
            this.listMiembros.SelectedIndexChanged += new System.EventHandler(this.listMiembros_SelectedIndexChanged);
            // 
            // Num
            // 
            this.Num.Text = "Num";
            // 
            // Cedula
            // 
            this.Cedula.Text = "Cedula";
            this.Cedula.Width = 71;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 135;
            // 
            // Aportes
            // 
            this.Aportes.Text = "Aportes";
            this.Aportes.Width = 97;
            // 
            // Deuda
            // 
            this.Deuda.Text = "Deuda";
            this.Deuda.Width = 84;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(3, 454);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 25);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Miembro";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(173, 454);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 25);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Miembro";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReporteGeneral
            // 
            this.btnReporteGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteGeneral.Location = new System.Drawing.Point(397, 537);
            this.btnReporteGeneral.Name = "btnReporteGeneral";
            this.btnReporteGeneral.Size = new System.Drawing.Size(120, 25);
            this.btnReporteGeneral.TabIndex = 1;
            this.btnReporteGeneral.Text = "Reporte General";
            this.btnReporteGeneral.UseVisualStyleBackColor = true;
            this.btnReporteGeneral.Click += new System.EventHandler(this.btnReporteGeneral_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(57, 537);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 25);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(226, 536);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(120, 25);
            this.btnCargarDatos.TabIndex = 3;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Sesión :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(348, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCerrrar
            // 
            this.btnCerrrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrrar.Location = new System.Drawing.Point(583, 536);
            this.btnCerrrar.Name = "btnCerrrar";
            this.btnCerrrar.Size = new System.Drawing.Size(121, 25);
            this.btnCerrrar.TabIndex = 8;
            this.btnCerrrar.Text = "Terminar Sesión";
            this.btnCerrrar.UseVisualStyleBackColor = true;
            this.btnCerrrar.Click += new System.EventHandler(this.btnCerrrar_Click);
            // 
            // btnCalcularPagosF
            // 
            this.btnCalcularPagosF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPagosF.Location = new System.Drawing.Point(767, 537);
            this.btnCalcularPagosF.Name = "btnCalcularPagosF";
            this.btnCalcularPagosF.Size = new System.Drawing.Size(119, 25);
            this.btnCalcularPagosF.TabIndex = 9;
            this.btnCalcularPagosF.Text = "Calcular Pagos Fondo";
            this.btnCalcularPagosF.UseVisualStyleBackColor = true;
            this.btnCalcularPagosF.Click += new System.EventHandler(this.btnCalcularPagosF_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(12, 12);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(105, 16);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "Nombre Fondo :";
            // 
            // infoNombreFondo
            // 
            this.infoNombreFondo.AutoSize = true;
            this.infoNombreFondo.BackColor = System.Drawing.Color.Transparent;
            this.infoNombreFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoNombreFondo.Location = new System.Drawing.Point(123, 12);
            this.infoNombreFondo.Name = "infoNombreFondo";
            this.infoNombreFondo.Size = new System.Drawing.Size(16, 16);
            this.infoNombreFondo.TabIndex = 11;
            this.infoNombreFondo.Text = "--";
            // 
            // btnModificarMiembro
            // 
            this.btnModificarMiembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMiembro.Location = new System.Drawing.Point(69, 460);
            this.btnModificarMiembro.Name = "btnModificarMiembro";
            this.btnModificarMiembro.Size = new System.Drawing.Size(138, 25);
            this.btnModificarMiembro.TabIndex = 23;
            this.btnModificarMiembro.Text = "Modificar Miembro";
            this.btnModificarMiembro.UseVisualStyleBackColor = true;
            this.btnModificarMiembro.Click += new System.EventHandler(this.button3_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 572);
            this.Controls.Add(this.infoNombreFondo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.btnCalcularPagosF);
            this.Controls.Add(this.btnCerrrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnReporteGeneral);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labCedula;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Button btnReporteMiembro;
        private System.Windows.Forms.Label labAportes;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labAporte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Button btnCuota;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReporteGeneral;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbAporteInfo;
        private System.Windows.Forms.Label imagenAporte;
        private System.Windows.Forms.Button btnEliminarT;
        private System.Windows.Forms.Button btnAgregarT;
        private System.Windows.Forms.Label infoDineroPrestamo;
        private System.Windows.Forms.Label infoTotalMiembros;
        private System.Windows.Forms.Label infoRendimiento;
        private System.Windows.Forms.Label infoValorAporte;
        private System.Windows.Forms.Label infoAportes;
        private System.Windows.Forms.Label lbnDineroPrestado;
        private System.Windows.Forms.Label lbnTotalMiembros;
        private System.Windows.Forms.Label lbnRindeInfo;
        private System.Windows.Forms.Label lbnInfoValor;
        private System.Windows.Forms.ListView listMiembros;
        private System.Windows.Forms.ColumnHeader Cedula;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Aportes;
        private System.Windows.Forms.ColumnHeader Deuda;
        private System.Windows.Forms.Label infoAportesTotales;
        private System.Windows.Forms.Label infoFecha;
        private System.Windows.Forms.Label infoCedula;
        private System.Windows.Forms.Label infoNombre;
        private System.Windows.Forms.Label infoCorreo;
        private System.Windows.Forms.Label infoTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listMiembrosT;
        private System.Windows.Forms.ColumnHeader CedulaT;
        private System.Windows.Forms.ColumnHeader NombreT;
        private System.Windows.Forms.ColumnHeader DeudaT;
        private System.Windows.Forms.Label infoDisponible;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Label infoGanancias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoReferencia;
        private System.Windows.Forms.Label infoDireccion;
        private System.Windows.Forms.Label lbnReferencia;
        private System.Windows.Forms.Label lbnDirec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.Button btnCerrrar;
        private System.Windows.Forms.Button btnCalcularPagoM;
        private System.Windows.Forms.Button btnCalcularPagosF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label infoNombreFondo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnModificarMiembro;
    }
}