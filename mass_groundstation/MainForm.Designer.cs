using System.Drawing;

namespace mass_groundstation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.clear_log = new System.Windows.Forms.Button();
            this.enable_logging = new System.Windows.Forms.CheckBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Tab_Logs = new System.Windows.Forms.TabPage();
            this.Tab_Connection = new System.Windows.Forms.TabPage();
            this.label_connection_last_refresh_output = new System.Windows.Forms.Label();
            this.label_last_connection_refresh = new System.Windows.Forms.Label();
            this.label_TCP_STATUS_OUTPUT = new System.Windows.Forms.Label();
            this.label_STATUS_TCP = new System.Windows.Forms.Label();
            this.label_PING_TIME = new System.Windows.Forms.Label();
            this.button_connection_refresh = new System.Windows.Forms.Button();
            this.label_sek = new System.Windows.Forms.Label();
            this.label_PING_REFRESH = new System.Windows.Forms.Label();
            this.numericUpDown_ping_refresh = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TCP_PORT = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_UDP_PORT = new System.Windows.Forms.NumericUpDown();
            this.label_PING = new System.Windows.Forms.Label();
            this.checkBox_lock_IP_config = new System.Windows.Forms.CheckBox();
            this.textBox_GS_IP = new System.Windows.Forms.TextBox();
            this.textBox_EXP_IP = new System.Windows.Forms.TextBox();
            this.label_TCP_PORT = new System.Windows.Forms.Label();
            this.label_UDP_PORT = new System.Windows.Forms.Label();
            this.label_GS_IP = new System.Windows.Forms.Label();
            this.label_EXP_IP = new System.Windows.Forms.Label();
            this.Tab_Camera = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_CAM2_LOCK = new System.Windows.Forms.CheckBox();
            this.button_CAM2_STOP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CAM2_STATUS = new System.Windows.Forms.Label();
            this.button_CAM2_START = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_CAM1_LOCK = new System.Windows.Forms.CheckBox();
            this.button_CAM1_STOP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CAM1_STATUS = new System.Windows.Forms.Label();
            this.button_CAM1_START = new System.Windows.Forms.Button();
            this.Tab_Experiment = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkBox_Inflation_Outside_Lock = new System.Windows.Forms.CheckBox();
            this.checkBox_Inflation_Inside_Lock = new System.Windows.Forms.CheckBox();
            this.button_Inflation_Outside_Stop = new System.Windows.Forms.Button();
            this.button_Inflation_Inside_Stop = new System.Windows.Forms.Button();
            this.button_Inflation_Outside_Start = new System.Windows.Forms.Button();
            this.button_Inflation_Inside_Start = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label_status_UV_ST2 = new System.Windows.Forms.Label();
            this.label_status_UV_ST1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_UV_ST2_Lock = new System.Windows.Forms.CheckBox();
            this.checkBox_UV_ST1_Lock = new System.Windows.Forms.CheckBox();
            this.button_UV_ST2_OFF = new System.Windows.Forms.Button();
            this.button_UV_ST1_OFF = new System.Windows.Forms.Button();
            this.button_UV_ST2_ON = new System.Windows.Forms.Button();
            this.button_UV_ST1_ON = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox_HDRM_Outside_Lock = new System.Windows.Forms.CheckBox();
            this.checkBox_HDRM_Inside_Lock = new System.Windows.Forms.CheckBox();
            this.button_HDRM_Outside_Release = new System.Windows.Forms.Button();
            this.button_HDRM_Inside_Release = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_voltage = new System.Windows.Forms.Label();
            this.textBox_EXTRA_Power = new System.Windows.Forms.TextBox();
            this.textBox_BEXUS_Power = new System.Windows.Forms.TextBox();
            this.textBox_EXTRA_Current = new System.Windows.Forms.TextBox();
            this.textBox_BEXUS_Current = new System.Windows.Forms.TextBox();
            this.label_EXTRA_BAT = new System.Windows.Forms.Label();
            this.label_BEXUS_BAT = new System.Windows.Forms.Label();
            this.textBox_EXTRA_Voltage = new System.Windows.Forms.TextBox();
            this.textBox_BEXUS_Voltage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_valve_ambient_inside = new System.Windows.Forms.Button();
            this.button_valve_ambient_outside = new System.Windows.Forms.Button();
            this.button_valve_pressure_outside = new System.Windows.Forms.Button();
            this.button_valve_pressure_inside = new System.Windows.Forms.Button();
            this.checkBox_pneu_manual_override = new System.Windows.Forms.CheckBox();
            this.label_valve_ambient_outside = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label_valve_ambient_inside = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_valve_pressure_outside = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_valve_pressure_inside = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_PNEU_Tank = new System.Windows.Forms.TextBox();
            this.textBox_PNEU_Inside_Structures = new System.Windows.Forms.TextBox();
            this.textBox_PNEU_Outside_Structures = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tab_Ambient_Conditions = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart_pressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_amb_pres = new System.Windows.Forms.Label();
            this.textBox_current_ambient_pressure = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_amb_temp_2 = new System.Windows.Forms.Label();
            this.textBox_current_ambient_temperature_outside = new System.Windows.Forms.TextBox();
            this.chart_temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_amb_temp_1 = new System.Windows.Forms.Label();
            this.textBox_current_ambient_temperature_inside = new System.Windows.Forms.TextBox();
            this.timer_ping_refresh = new System.Windows.Forms.Timer(this.components);
            this.TabControl.SuspendLayout();
            this.Tab_Logs.SuspendLayout();
            this.Tab_Connection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ping_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TCP_PORT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UDP_PORT)).BeginInit();
            this.Tab_Camera.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Tab_Experiment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tab_Ambient_Conditions.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pressure)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temperature)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusBar.Location = new System.Drawing.Point(-154, 801);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(202, 22);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "StatusBar";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(8, 35);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(1489, 731);
            this.OutputTextBox.TabIndex = 1;
            this.OutputTextBox.Text = "";
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // clear_log
            // 
            this.clear_log.Location = new System.Drawing.Point(114, 6);
            this.clear_log.Name = "clear_log";
            this.clear_log.Size = new System.Drawing.Size(90, 23);
            this.clear_log.TabIndex = 3;
            this.clear_log.Text = "Clear Log File";
            this.clear_log.UseVisualStyleBackColor = true;
            this.clear_log.Click += new System.EventHandler(this.clear_log_Click);
            // 
            // enable_logging
            // 
            this.enable_logging.AutoSize = true;
            this.enable_logging.Checked = true;
            this.enable_logging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enable_logging.Location = new System.Drawing.Point(8, 6);
            this.enable_logging.Name = "enable_logging";
            this.enable_logging.Size = new System.Drawing.Size(100, 17);
            this.enable_logging.TabIndex = 4;
            this.enable_logging.Text = "Enable Logging";
            this.enable_logging.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.Tab_Logs);
            this.TabControl.Controls.Add(this.Tab_Connection);
            this.TabControl.Controls.Add(this.Tab_Camera);
            this.TabControl.Controls.Add(this.Tab_Experiment);
            this.TabControl.Controls.Add(this.tab_Ambient_Conditions);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1513, 798);
            this.TabControl.TabIndex = 5;
            // 
            // Tab_Logs
            // 
            this.Tab_Logs.Controls.Add(this.enable_logging);
            this.Tab_Logs.Controls.Add(this.OutputTextBox);
            this.Tab_Logs.Controls.Add(this.clear_log);
            this.Tab_Logs.Location = new System.Drawing.Point(4, 22);
            this.Tab_Logs.Name = "Tab_Logs";
            this.Tab_Logs.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Logs.Size = new System.Drawing.Size(1505, 772);
            this.Tab_Logs.TabIndex = 0;
            this.Tab_Logs.Text = "Logs";
            this.Tab_Logs.UseVisualStyleBackColor = true;
            // 
            // Tab_Connection
            // 
            this.Tab_Connection.Controls.Add(this.label_connection_last_refresh_output);
            this.Tab_Connection.Controls.Add(this.label_last_connection_refresh);
            this.Tab_Connection.Controls.Add(this.label_TCP_STATUS_OUTPUT);
            this.Tab_Connection.Controls.Add(this.label_STATUS_TCP);
            this.Tab_Connection.Controls.Add(this.label_PING_TIME);
            this.Tab_Connection.Controls.Add(this.button_connection_refresh);
            this.Tab_Connection.Controls.Add(this.label_sek);
            this.Tab_Connection.Controls.Add(this.label_PING_REFRESH);
            this.Tab_Connection.Controls.Add(this.numericUpDown_ping_refresh);
            this.Tab_Connection.Controls.Add(this.numericUpDown_TCP_PORT);
            this.Tab_Connection.Controls.Add(this.numericUpDown_UDP_PORT);
            this.Tab_Connection.Controls.Add(this.label_PING);
            this.Tab_Connection.Controls.Add(this.checkBox_lock_IP_config);
            this.Tab_Connection.Controls.Add(this.textBox_GS_IP);
            this.Tab_Connection.Controls.Add(this.textBox_EXP_IP);
            this.Tab_Connection.Controls.Add(this.label_TCP_PORT);
            this.Tab_Connection.Controls.Add(this.label_UDP_PORT);
            this.Tab_Connection.Controls.Add(this.label_GS_IP);
            this.Tab_Connection.Controls.Add(this.label_EXP_IP);
            this.Tab_Connection.Location = new System.Drawing.Point(4, 22);
            this.Tab_Connection.Name = "Tab_Connection";
            this.Tab_Connection.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Connection.Size = new System.Drawing.Size(1505, 772);
            this.Tab_Connection.TabIndex = 1;
            this.Tab_Connection.Text = "Connection";
            this.Tab_Connection.UseVisualStyleBackColor = true;
            // 
            // label_connection_last_refresh_output
            // 
            this.label_connection_last_refresh_output.AutoSize = true;
            this.label_connection_last_refresh_output.BackColor = System.Drawing.Color.Transparent;
            this.label_connection_last_refresh_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connection_last_refresh_output.Location = new System.Drawing.Point(176, 203);
            this.label_connection_last_refresh_output.Name = "label_connection_last_refresh_output";
            this.label_connection_last_refresh_output.Size = new System.Drawing.Size(53, 15);
            this.label_connection_last_refresh_output.TabIndex = 27;
            this.label_connection_last_refresh_output.Text = "NEVER";
            // 
            // label_last_connection_refresh
            // 
            this.label_last_connection_refresh.AutoSize = true;
            this.label_last_connection_refresh.BackColor = System.Drawing.Color.Transparent;
            this.label_last_connection_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_last_connection_refresh.Location = new System.Drawing.Point(32, 202);
            this.label_last_connection_refresh.Name = "label_last_connection_refresh";
            this.label_last_connection_refresh.Size = new System.Drawing.Size(95, 16);
            this.label_last_connection_refresh.TabIndex = 26;
            this.label_last_connection_refresh.Text = "Last Refresh";
            // 
            // label_TCP_STATUS_OUTPUT
            // 
            this.label_TCP_STATUS_OUTPUT.AutoSize = true;
            this.label_TCP_STATUS_OUTPUT.BackColor = System.Drawing.Color.Transparent;
            this.label_TCP_STATUS_OUTPUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TCP_STATUS_OUTPUT.ForeColor = System.Drawing.Color.Red;
            this.label_TCP_STATUS_OUTPUT.Location = new System.Drawing.Point(176, 185);
            this.label_TCP_STATUS_OUTPUT.Name = "label_TCP_STATUS_OUTPUT";
            this.label_TCP_STATUS_OUTPUT.Size = new System.Drawing.Size(123, 15);
            this.label_TCP_STATUS_OUTPUT.TabIndex = 24;
            this.label_TCP_STATUS_OUTPUT.Text = "NOT CONNECTED";
            // 
            // label_STATUS_TCP
            // 
            this.label_STATUS_TCP.AutoSize = true;
            this.label_STATUS_TCP.BackColor = System.Drawing.Color.Transparent;
            this.label_STATUS_TCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_STATUS_TCP.Location = new System.Drawing.Point(32, 186);
            this.label_STATUS_TCP.Name = "label_STATUS_TCP";
            this.label_STATUS_TCP.Size = new System.Drawing.Size(38, 16);
            this.label_STATUS_TCP.TabIndex = 22;
            this.label_STATUS_TCP.Text = "TCP";
            // 
            // label_PING_TIME
            // 
            this.label_PING_TIME.AutoSize = true;
            this.label_PING_TIME.BackColor = System.Drawing.Color.Transparent;
            this.label_PING_TIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PING_TIME.ForeColor = System.Drawing.Color.Red;
            this.label_PING_TIME.Location = new System.Drawing.Point(176, 170);
            this.label_PING_TIME.Name = "label_PING_TIME";
            this.label_PING_TIME.Size = new System.Drawing.Size(123, 15);
            this.label_PING_TIME.TabIndex = 20;
            this.label_PING_TIME.Text = "NOT CONNECTED";
            // 
            // button_connection_refresh
            // 
            this.button_connection_refresh.Location = new System.Drawing.Point(179, 247);
            this.button_connection_refresh.Name = "button_connection_refresh";
            this.button_connection_refresh.Size = new System.Drawing.Size(100, 23);
            this.button_connection_refresh.TabIndex = 18;
            this.button_connection_refresh.Text = "Refresh";
            this.button_connection_refresh.UseVisualStyleBackColor = true;
            this.button_connection_refresh.Click += new System.EventHandler(this.button_single_PING_Click);
            // 
            // label_sek
            // 
            this.label_sek.AutoSize = true;
            this.label_sek.Location = new System.Drawing.Point(241, 223);
            this.label_sek.Name = "label_sek";
            this.label_sek.Size = new System.Drawing.Size(38, 13);
            this.label_sek.TabIndex = 17;
            this.label_sek.Text = "in sec.";
            // 
            // label_PING_REFRESH
            // 
            this.label_PING_REFRESH.AutoSize = true;
            this.label_PING_REFRESH.BackColor = System.Drawing.Color.Transparent;
            this.label_PING_REFRESH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PING_REFRESH.Location = new System.Drawing.Point(32, 221);
            this.label_PING_REFRESH.Name = "label_PING_REFRESH";
            this.label_PING_REFRESH.Size = new System.Drawing.Size(99, 16);
            this.label_PING_REFRESH.TabIndex = 16;
            this.label_PING_REFRESH.Text = "Refresh Rate";
            // 
            // numericUpDown_ping_refresh
            // 
            this.numericUpDown_ping_refresh.Location = new System.Drawing.Point(179, 221);
            this.numericUpDown_ping_refresh.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_ping_refresh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ping_refresh.Name = "numericUpDown_ping_refresh";
            this.numericUpDown_ping_refresh.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown_ping_refresh.TabIndex = 15;
            this.numericUpDown_ping_refresh.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_ping_refresh.ValueChanged += new System.EventHandler(this.numericUpDown_ping_refresh_ValueChanged);
            // 
            // numericUpDown_TCP_PORT
            // 
            this.numericUpDown_TCP_PORT.Location = new System.Drawing.Point(179, 108);
            this.numericUpDown_TCP_PORT.Name = "numericUpDown_TCP_PORT";
            this.numericUpDown_TCP_PORT.ReadOnly = true;
            this.numericUpDown_TCP_PORT.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_TCP_PORT.TabIndex = 14;
            this.numericUpDown_TCP_PORT.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_UDP_PORT
            // 
            this.numericUpDown_UDP_PORT.Location = new System.Drawing.Point(179, 82);
            this.numericUpDown_UDP_PORT.Name = "numericUpDown_UDP_PORT";
            this.numericUpDown_UDP_PORT.ReadOnly = true;
            this.numericUpDown_UDP_PORT.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_UDP_PORT.TabIndex = 13;
            this.numericUpDown_UDP_PORT.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label_PING
            // 
            this.label_PING.AutoSize = true;
            this.label_PING.BackColor = System.Drawing.Color.Transparent;
            this.label_PING.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PING.Location = new System.Drawing.Point(32, 170);
            this.label_PING.Name = "label_PING";
            this.label_PING.Size = new System.Drawing.Size(44, 16);
            this.label_PING.TabIndex = 10;
            this.label_PING.Text = "PING";
            // 
            // checkBox_lock_IP_config
            // 
            this.checkBox_lock_IP_config.AutoSize = true;
            this.checkBox_lock_IP_config.Checked = true;
            this.checkBox_lock_IP_config.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_lock_IP_config.Location = new System.Drawing.Point(179, 134);
            this.checkBox_lock_IP_config.Name = "checkBox_lock_IP_config";
            this.checkBox_lock_IP_config.Size = new System.Drawing.Size(68, 17);
            this.checkBox_lock_IP_config.TabIndex = 9;
            this.checkBox_lock_IP_config.Text = "Lock IPs";
            this.checkBox_lock_IP_config.UseVisualStyleBackColor = true;
            this.checkBox_lock_IP_config.CheckedChanged += new System.EventHandler(this.checkBox_lock_IP_config_CheckedChanged);
            // 
            // textBox_GS_IP
            // 
            this.textBox_GS_IP.Location = new System.Drawing.Point(179, 56);
            this.textBox_GS_IP.Name = "textBox_GS_IP";
            this.textBox_GS_IP.ReadOnly = true;
            this.textBox_GS_IP.Size = new System.Drawing.Size(100, 20);
            this.textBox_GS_IP.TabIndex = 7;
            this.textBox_GS_IP.Text = "192.168.2.106";
            // 
            // textBox_EXP_IP
            // 
            this.textBox_EXP_IP.Location = new System.Drawing.Point(179, 30);
            this.textBox_EXP_IP.Name = "textBox_EXP_IP";
            this.textBox_EXP_IP.ReadOnly = true;
            this.textBox_EXP_IP.Size = new System.Drawing.Size(100, 20);
            this.textBox_EXP_IP.TabIndex = 4;
            this.textBox_EXP_IP.Text = "192.168.2.112";
            // 
            // label_TCP_PORT
            // 
            this.label_TCP_PORT.AutoSize = true;
            this.label_TCP_PORT.BackColor = System.Drawing.Color.Transparent;
            this.label_TCP_PORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TCP_PORT.Location = new System.Drawing.Point(32, 112);
            this.label_TCP_PORT.Name = "label_TCP_PORT";
            this.label_TCP_PORT.Size = new System.Drawing.Size(84, 16);
            this.label_TCP_PORT.TabIndex = 3;
            this.label_TCP_PORT.Text = "TCP PORT";
            // 
            // label_UDP_PORT
            // 
            this.label_UDP_PORT.AutoSize = true;
            this.label_UDP_PORT.BackColor = System.Drawing.Color.Transparent;
            this.label_UDP_PORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UDP_PORT.Location = new System.Drawing.Point(32, 86);
            this.label_UDP_PORT.Name = "label_UDP_PORT";
            this.label_UDP_PORT.Size = new System.Drawing.Size(86, 16);
            this.label_UDP_PORT.TabIndex = 2;
            this.label_UDP_PORT.Text = "UDP PORT";
            // 
            // label_GS_IP
            // 
            this.label_GS_IP.AutoSize = true;
            this.label_GS_IP.BackColor = System.Drawing.Color.Transparent;
            this.label_GS_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GS_IP.Location = new System.Drawing.Point(32, 60);
            this.label_GS_IP.Name = "label_GS_IP";
            this.label_GS_IP.Size = new System.Drawing.Size(128, 16);
            this.label_GS_IP.TabIndex = 1;
            this.label_GS_IP.Text = "Ground Station IP";
            // 
            // label_EXP_IP
            // 
            this.label_EXP_IP.AutoSize = true;
            this.label_EXP_IP.BackColor = System.Drawing.Color.Transparent;
            this.label_EXP_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EXP_IP.Location = new System.Drawing.Point(32, 34);
            this.label_EXP_IP.Name = "label_EXP_IP";
            this.label_EXP_IP.Size = new System.Drawing.Size(103, 16);
            this.label_EXP_IP.TabIndex = 0;
            this.label_EXP_IP.Text = "Experiment IP";
            // 
            // Tab_Camera
            // 
            this.Tab_Camera.Controls.Add(this.groupBox2);
            this.Tab_Camera.Controls.Add(this.groupBox1);
            this.Tab_Camera.Location = new System.Drawing.Point(4, 22);
            this.Tab_Camera.Name = "Tab_Camera";
            this.Tab_Camera.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Camera.Size = new System.Drawing.Size(1505, 772);
            this.Tab_Camera.TabIndex = 2;
            this.Tab_Camera.Text = "Camera";
            this.Tab_Camera.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox_CAM2_LOCK);
            this.groupBox2.Controls.Add(this.button_CAM2_STOP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_CAM2_STATUS);
            this.groupBox2.Controls.Add(this.button_CAM2_START);
            this.groupBox2.Location = new System.Drawing.Point(759, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera 2";
            // 
            // checkBox_CAM2_LOCK
            // 
            this.checkBox_CAM2_LOCK.AutoSize = true;
            this.checkBox_CAM2_LOCK.Location = new System.Drawing.Point(6, 48);
            this.checkBox_CAM2_LOCK.Name = "checkBox_CAM2_LOCK";
            this.checkBox_CAM2_LOCK.Size = new System.Drawing.Size(77, 17);
            this.checkBox_CAM2_LOCK.TabIndex = 1;
            this.checkBox_CAM2_LOCK.Text = "Lock Input";
            this.checkBox_CAM2_LOCK.UseVisualStyleBackColor = true;
            // 
            // button_CAM2_STOP
            // 
            this.button_CAM2_STOP.Location = new System.Drawing.Point(114, 19);
            this.button_CAM2_STOP.Name = "button_CAM2_STOP";
            this.button_CAM2_STOP.Size = new System.Drawing.Size(95, 23);
            this.button_CAM2_STOP.TabIndex = 3;
            this.button_CAM2_STOP.Text = "Stop Recording";
            this.button_CAM2_STOP.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status:";
            // 
            // label_CAM2_STATUS
            // 
            this.label_CAM2_STATUS.AutoSize = true;
            this.label_CAM2_STATUS.ForeColor = System.Drawing.Color.Red;
            this.label_CAM2_STATUS.Location = new System.Drawing.Point(271, 24);
            this.label_CAM2_STATUS.Name = "label_CAM2_STATUS";
            this.label_CAM2_STATUS.Size = new System.Drawing.Size(98, 13);
            this.label_CAM2_STATUS.TabIndex = 1;
            this.label_CAM2_STATUS.Text = "NOT RECORDING";
            // 
            // button_CAM2_START
            // 
            this.button_CAM2_START.Location = new System.Drawing.Point(6, 19);
            this.button_CAM2_START.Name = "button_CAM2_START";
            this.button_CAM2_START.Size = new System.Drawing.Size(102, 23);
            this.button_CAM2_START.TabIndex = 2;
            this.button_CAM2_START.Text = "Start Recording";
            this.button_CAM2_START.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.checkBox_CAM1_LOCK);
            this.groupBox1.Controls.Add(this.button_CAM1_STOP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_CAM1_STATUS);
            this.groupBox1.Controls.Add(this.button_CAM1_START);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera 1";
            // 
            // checkBox_CAM1_LOCK
            // 
            this.checkBox_CAM1_LOCK.AutoSize = true;
            this.checkBox_CAM1_LOCK.Location = new System.Drawing.Point(6, 48);
            this.checkBox_CAM1_LOCK.Name = "checkBox_CAM1_LOCK";
            this.checkBox_CAM1_LOCK.Size = new System.Drawing.Size(77, 17);
            this.checkBox_CAM1_LOCK.TabIndex = 1;
            this.checkBox_CAM1_LOCK.Text = "Lock Input";
            this.checkBox_CAM1_LOCK.UseVisualStyleBackColor = true;
            this.checkBox_CAM1_LOCK.CheckedChanged += new System.EventHandler(this.checkBox_CAM1_LOCK_CheckedChanged);
            // 
            // button_CAM1_STOP
            // 
            this.button_CAM1_STOP.Location = new System.Drawing.Point(114, 19);
            this.button_CAM1_STOP.Name = "button_CAM1_STOP";
            this.button_CAM1_STOP.Size = new System.Drawing.Size(95, 23);
            this.button_CAM1_STOP.TabIndex = 3;
            this.button_CAM1_STOP.Text = "Stop Recording";
            this.button_CAM1_STOP.UseVisualStyleBackColor = true;
            this.button_CAM1_STOP.Click += new System.EventHandler(this.button_CAM1_STOP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // label_CAM1_STATUS
            // 
            this.label_CAM1_STATUS.AutoSize = true;
            this.label_CAM1_STATUS.ForeColor = System.Drawing.Color.Red;
            this.label_CAM1_STATUS.Location = new System.Drawing.Point(271, 24);
            this.label_CAM1_STATUS.Name = "label_CAM1_STATUS";
            this.label_CAM1_STATUS.Size = new System.Drawing.Size(98, 13);
            this.label_CAM1_STATUS.TabIndex = 1;
            this.label_CAM1_STATUS.Text = "NOT RECORDING";
            // 
            // button_CAM1_START
            // 
            this.button_CAM1_START.Location = new System.Drawing.Point(6, 19);
            this.button_CAM1_START.Name = "button_CAM1_START";
            this.button_CAM1_START.Size = new System.Drawing.Size(102, 23);
            this.button_CAM1_START.TabIndex = 2;
            this.button_CAM1_START.Text = "Start Recording";
            this.button_CAM1_START.UseVisualStyleBackColor = true;
            this.button_CAM1_START.Click += new System.EventHandler(this.button_CAM1_START_Click);
            // 
            // Tab_Experiment
            // 
            this.Tab_Experiment.Controls.Add(this.pictureBox3);
            this.Tab_Experiment.Controls.Add(this.groupBox9);
            this.Tab_Experiment.Controls.Add(this.groupBox7);
            this.Tab_Experiment.Controls.Add(this.groupBox6);
            this.Tab_Experiment.Controls.Add(this.groupBox8);
            this.Tab_Experiment.Controls.Add(this.groupBox5);
            this.Tab_Experiment.Location = new System.Drawing.Point(4, 22);
            this.Tab_Experiment.Name = "Tab_Experiment";
            this.Tab_Experiment.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Experiment.Size = new System.Drawing.Size(1505, 772);
            this.Tab_Experiment.TabIndex = 3;
            this.Tab_Experiment.Text = "Experiment";
            this.Tab_Experiment.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(221, 517);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(291, 249);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.checkBox_Inflation_Outside_Lock);
            this.groupBox9.Controls.Add(this.checkBox_Inflation_Inside_Lock);
            this.groupBox9.Controls.Add(this.button_Inflation_Outside_Stop);
            this.groupBox9.Controls.Add(this.button_Inflation_Inside_Stop);
            this.groupBox9.Controls.Add(this.button_Inflation_Outside_Start);
            this.groupBox9.Controls.Add(this.button_Inflation_Inside_Start);
            this.groupBox9.Location = new System.Drawing.Point(9, 228);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(737, 129);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Pneumatics";
            // 
            // checkBox_Inflation_Outside_Lock
            // 
            this.checkBox_Inflation_Outside_Lock.AutoSize = true;
            this.checkBox_Inflation_Outside_Lock.Checked = true;
            this.checkBox_Inflation_Outside_Lock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Inflation_Outside_Lock.Location = new System.Drawing.Point(403, 89);
            this.checkBox_Inflation_Outside_Lock.Name = "checkBox_Inflation_Outside_Lock";
            this.checkBox_Inflation_Outside_Lock.Size = new System.Drawing.Size(129, 17);
            this.checkBox_Inflation_Outside_Lock.TabIndex = 8;
            this.checkBox_Inflation_Outside_Lock.Text = "Lock Inflation Outside";
            this.checkBox_Inflation_Outside_Lock.UseVisualStyleBackColor = true;
            this.checkBox_Inflation_Outside_Lock.CheckedChanged += new System.EventHandler(this.checkBox_Inflation_Outside_Lock_CheckedChanged);
            // 
            // checkBox_Inflation_Inside_Lock
            // 
            this.checkBox_Inflation_Inside_Lock.AutoSize = true;
            this.checkBox_Inflation_Inside_Lock.Checked = true;
            this.checkBox_Inflation_Inside_Lock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Inflation_Inside_Lock.Location = new System.Drawing.Point(84, 89);
            this.checkBox_Inflation_Inside_Lock.Name = "checkBox_Inflation_Inside_Lock";
            this.checkBox_Inflation_Inside_Lock.Size = new System.Drawing.Size(121, 17);
            this.checkBox_Inflation_Inside_Lock.TabIndex = 7;
            this.checkBox_Inflation_Inside_Lock.Text = "Lock Inflation Inside";
            this.checkBox_Inflation_Inside_Lock.UseVisualStyleBackColor = true;
            this.checkBox_Inflation_Inside_Lock.CheckedChanged += new System.EventHandler(this.checkBox_Inflation_Inside_Lock_CheckedChanged);
            // 
            // button_Inflation_Outside_Stop
            // 
            this.button_Inflation_Outside_Stop.Enabled = false;
            this.button_Inflation_Outside_Stop.Location = new System.Drawing.Point(403, 60);
            this.button_Inflation_Outside_Stop.Name = "button_Inflation_Outside_Stop";
            this.button_Inflation_Outside_Stop.Size = new System.Drawing.Size(253, 23);
            this.button_Inflation_Outside_Stop.TabIndex = 7;
            this.button_Inflation_Outside_Stop.Text = "Inflation Stop Outside";
            this.button_Inflation_Outside_Stop.UseVisualStyleBackColor = true;
            // 
            // button_Inflation_Inside_Stop
            // 
            this.button_Inflation_Inside_Stop.Enabled = false;
            this.button_Inflation_Inside_Stop.Location = new System.Drawing.Point(84, 60);
            this.button_Inflation_Inside_Stop.Name = "button_Inflation_Inside_Stop";
            this.button_Inflation_Inside_Stop.Size = new System.Drawing.Size(253, 23);
            this.button_Inflation_Inside_Stop.TabIndex = 6;
            this.button_Inflation_Inside_Stop.Text = "Inflation Stop Inside";
            this.button_Inflation_Inside_Stop.UseVisualStyleBackColor = true;
            // 
            // button_Inflation_Outside_Start
            // 
            this.button_Inflation_Outside_Start.Enabled = false;
            this.button_Inflation_Outside_Start.Location = new System.Drawing.Point(404, 31);
            this.button_Inflation_Outside_Start.Name = "button_Inflation_Outside_Start";
            this.button_Inflation_Outside_Start.Size = new System.Drawing.Size(253, 23);
            this.button_Inflation_Outside_Start.TabIndex = 5;
            this.button_Inflation_Outside_Start.Text = "Inflation Start Outside";
            this.button_Inflation_Outside_Start.UseVisualStyleBackColor = true;
            // 
            // button_Inflation_Inside_Start
            // 
            this.button_Inflation_Inside_Start.Enabled = false;
            this.button_Inflation_Inside_Start.Location = new System.Drawing.Point(84, 31);
            this.button_Inflation_Inside_Start.Name = "button_Inflation_Inside_Start";
            this.button_Inflation_Inside_Start.Size = new System.Drawing.Size(253, 23);
            this.button_Inflation_Inside_Start.TabIndex = 4;
            this.button_Inflation_Inside_Start.Text = "Inflation Start Inside";
            this.button_Inflation_Inside_Start.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label_status_UV_ST2);
            this.groupBox7.Controls.Add(this.label_status_UV_ST1);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.checkBox_UV_ST2_Lock);
            this.groupBox7.Controls.Add(this.checkBox_UV_ST1_Lock);
            this.groupBox7.Controls.Add(this.button_UV_ST2_OFF);
            this.groupBox7.Controls.Add(this.button_UV_ST1_OFF);
            this.groupBox7.Controls.Add(this.button_UV_ST2_ON);
            this.groupBox7.Controls.Add(this.button_UV_ST1_ON);
            this.groupBox7.Location = new System.Drawing.Point(8, 363);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(737, 149);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "UV Leds";
            // 
            // label_status_UV_ST2
            // 
            this.label_status_UV_ST2.AutoSize = true;
            this.label_status_UV_ST2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status_UV_ST2.ForeColor = System.Drawing.Color.Red;
            this.label_status_UV_ST2.Location = new System.Drawing.Point(446, 111);
            this.label_status_UV_ST2.Name = "label_status_UV_ST2";
            this.label_status_UV_ST2.Size = new System.Drawing.Size(33, 15);
            this.label_status_UV_ST2.TabIndex = 10;
            this.label_status_UV_ST2.Text = "OFF";
            this.label_status_UV_ST2.Click += new System.EventHandler(this.label21_Click);
            // 
            // label_status_UV_ST1
            // 
            this.label_status_UV_ST1.AutoSize = true;
            this.label_status_UV_ST1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status_UV_ST1.ForeColor = System.Drawing.Color.Red;
            this.label_status_UV_ST1.Location = new System.Drawing.Point(132, 111);
            this.label_status_UV_ST1.Name = "label_status_UV_ST1";
            this.label_status_UV_ST1.Size = new System.Drawing.Size(33, 15);
            this.label_status_UV_ST1.TabIndex = 9;
            this.label_status_UV_ST1.Text = "OFF";
            this.label_status_UV_ST1.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(400, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status:";
            // 
            // checkBox_UV_ST2_Lock
            // 
            this.checkBox_UV_ST2_Lock.AutoSize = true;
            this.checkBox_UV_ST2_Lock.Checked = true;
            this.checkBox_UV_ST2_Lock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_UV_ST2_Lock.Location = new System.Drawing.Point(403, 89);
            this.checkBox_UV_ST2_Lock.Name = "checkBox_UV_ST2_Lock";
            this.checkBox_UV_ST2_Lock.Size = new System.Drawing.Size(123, 17);
            this.checkBox_UV_ST2_Lock.TabIndex = 6;
            this.checkBox_UV_ST2_Lock.Text = "Lock UV Structure 1";
            this.checkBox_UV_ST2_Lock.UseVisualStyleBackColor = true;
            this.checkBox_UV_ST2_Lock.CheckedChanged += new System.EventHandler(this.checkBox_UV_ST2_Lock_CheckedChanged);
            // 
            // checkBox_UV_ST1_Lock
            // 
            this.checkBox_UV_ST1_Lock.AutoSize = true;
            this.checkBox_UV_ST1_Lock.Checked = true;
            this.checkBox_UV_ST1_Lock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_UV_ST1_Lock.Location = new System.Drawing.Point(86, 89);
            this.checkBox_UV_ST1_Lock.Name = "checkBox_UV_ST1_Lock";
            this.checkBox_UV_ST1_Lock.Size = new System.Drawing.Size(123, 17);
            this.checkBox_UV_ST1_Lock.TabIndex = 5;
            this.checkBox_UV_ST1_Lock.Text = "Lock UV Structure 1";
            this.checkBox_UV_ST1_Lock.UseVisualStyleBackColor = true;
            this.checkBox_UV_ST1_Lock.CheckedChanged += new System.EventHandler(this.checkBox_UV_ST1_Lock_CheckedChanged);
            // 
            // button_UV_ST2_OFF
            // 
            this.button_UV_ST2_OFF.Enabled = false;
            this.button_UV_ST2_OFF.Location = new System.Drawing.Point(403, 60);
            this.button_UV_ST2_OFF.Name = "button_UV_ST2_OFF";
            this.button_UV_ST2_OFF.Size = new System.Drawing.Size(253, 23);
            this.button_UV_ST2_OFF.TabIndex = 4;
            this.button_UV_ST2_OFF.Text = "UV - OFF Structure 2";
            this.button_UV_ST2_OFF.UseVisualStyleBackColor = true;
            // 
            // button_UV_ST1_OFF
            // 
            this.button_UV_ST1_OFF.Enabled = false;
            this.button_UV_ST1_OFF.Location = new System.Drawing.Point(86, 60);
            this.button_UV_ST1_OFF.Name = "button_UV_ST1_OFF";
            this.button_UV_ST1_OFF.Size = new System.Drawing.Size(253, 23);
            this.button_UV_ST1_OFF.TabIndex = 3;
            this.button_UV_ST1_OFF.Text = "UV - OFF Structure 1";
            this.button_UV_ST1_OFF.UseVisualStyleBackColor = true;
            // 
            // button_UV_ST2_ON
            // 
            this.button_UV_ST2_ON.Enabled = false;
            this.button_UV_ST2_ON.Location = new System.Drawing.Point(403, 31);
            this.button_UV_ST2_ON.Name = "button_UV_ST2_ON";
            this.button_UV_ST2_ON.Size = new System.Drawing.Size(253, 23);
            this.button_UV_ST2_ON.TabIndex = 2;
            this.button_UV_ST2_ON.Text = "UV - ON Structure 2";
            this.button_UV_ST2_ON.UseVisualStyleBackColor = true;
            // 
            // button_UV_ST1_ON
            // 
            this.button_UV_ST1_ON.Enabled = false;
            this.button_UV_ST1_ON.Location = new System.Drawing.Point(86, 31);
            this.button_UV_ST1_ON.Name = "button_UV_ST1_ON";
            this.button_UV_ST1_ON.Size = new System.Drawing.Size(253, 23);
            this.button_UV_ST1_ON.TabIndex = 1;
            this.button_UV_ST1_ON.Text = "UV - ON Structure 1";
            this.button_UV_ST1_ON.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox_HDRM_Outside_Lock);
            this.groupBox6.Controls.Add(this.checkBox_HDRM_Inside_Lock);
            this.groupBox6.Controls.Add(this.button_HDRM_Outside_Release);
            this.groupBox6.Controls.Add(this.button_HDRM_Inside_Release);
            this.groupBox6.Location = new System.Drawing.Point(9, 127);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(737, 95);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "HDRM";
            // 
            // checkBox_HDRM_Outside_Lock
            // 
            this.checkBox_HDRM_Outside_Lock.AutoSize = true;
            this.checkBox_HDRM_Outside_Lock.Checked = true;
            this.checkBox_HDRM_Outside_Lock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_HDRM_Outside_Lock.Location = new System.Drawing.Point(403, 58);
            this.checkBox_HDRM_Outside_Lock.Name = "checkBox_HDRM_Outside_Lock";
            this.checkBox_HDRM_Outside_Lock.Size = new System.Drawing.Size(117, 17);
            this.checkBox_HDRM_Outside_Lock.TabIndex = 3;
            this.checkBox_HDRM_Outside_Lock.Text = "Lock HDRM Inside";
            this.checkBox_HDRM_Outside_Lock.UseVisualStyleBackColor = true;
            this.checkBox_HDRM_Outside_Lock.CheckedChanged += new System.EventHandler(this.checkBox_HDRM_Outside_Lock_CheckedChanged);
            // 
            // checkBox_HDRM_Inside_Lock
            // 
            this.checkBox_HDRM_Inside_Lock.AutoSize = true;
            this.checkBox_HDRM_Inside_Lock.Checked = true;
            this.checkBox_HDRM_Inside_Lock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_HDRM_Inside_Lock.Location = new System.Drawing.Point(86, 58);
            this.checkBox_HDRM_Inside_Lock.Name = "checkBox_HDRM_Inside_Lock";
            this.checkBox_HDRM_Inside_Lock.Size = new System.Drawing.Size(117, 17);
            this.checkBox_HDRM_Inside_Lock.TabIndex = 2;
            this.checkBox_HDRM_Inside_Lock.Text = "Lock HDRM Inside";
            this.checkBox_HDRM_Inside_Lock.UseVisualStyleBackColor = true;
            this.checkBox_HDRM_Inside_Lock.CheckedChanged += new System.EventHandler(this.checkBox_HDRM_Inside_Lock_CheckedChanged);
            // 
            // button_HDRM_Outside_Release
            // 
            this.button_HDRM_Outside_Release.Enabled = false;
            this.button_HDRM_Outside_Release.Location = new System.Drawing.Point(403, 29);
            this.button_HDRM_Outside_Release.Name = "button_HDRM_Outside_Release";
            this.button_HDRM_Outside_Release.Size = new System.Drawing.Size(254, 23);
            this.button_HDRM_Outside_Release.TabIndex = 1;
            this.button_HDRM_Outside_Release.Text = "Release HDRM Outside";
            this.button_HDRM_Outside_Release.UseVisualStyleBackColor = true;
            // 
            // button_HDRM_Inside_Release
            // 
            this.button_HDRM_Inside_Release.Enabled = false;
            this.button_HDRM_Inside_Release.Location = new System.Drawing.Point(86, 29);
            this.button_HDRM_Inside_Release.Name = "button_HDRM_Inside_Release";
            this.button_HDRM_Inside_Release.Size = new System.Drawing.Size(253, 23);
            this.button_HDRM_Inside_Release.TabIndex = 0;
            this.button_HDRM_Inside_Release.Text = "Release HDRM Inside";
            this.button_HDRM_Inside_Release.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pictureBox1);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.label_voltage);
            this.groupBox8.Controls.Add(this.textBox_EXTRA_Power);
            this.groupBox8.Controls.Add(this.textBox_BEXUS_Power);
            this.groupBox8.Controls.Add(this.textBox_EXTRA_Current);
            this.groupBox8.Controls.Add(this.textBox_BEXUS_Current);
            this.groupBox8.Controls.Add(this.label_EXTRA_BAT);
            this.groupBox8.Controls.Add(this.label_BEXUS_BAT);
            this.groupBox8.Controls.Add(this.textBox_EXTRA_Voltage);
            this.groupBox8.Controls.Add(this.textBox_BEXUS_Voltage);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(740, 114);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Power";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(557, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Power";
            // 
            // label_voltage
            // 
            this.label_voltage.AutoSize = true;
            this.label_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_voltage.Location = new System.Drawing.Point(451, 25);
            this.label_voltage.Name = "label_voltage";
            this.label_voltage.Size = new System.Drawing.Size(48, 13);
            this.label_voltage.TabIndex = 1;
            this.label_voltage.Text = "Current";
            // 
            // textBox_EXTRA_Power
            // 
            this.textBox_EXTRA_Power.Location = new System.Drawing.Point(560, 67);
            this.textBox_EXTRA_Power.Name = "textBox_EXTRA_Power";
            this.textBox_EXTRA_Power.ReadOnly = true;
            this.textBox_EXTRA_Power.Size = new System.Drawing.Size(100, 20);
            this.textBox_EXTRA_Power.TabIndex = 7;
            // 
            // textBox_BEXUS_Power
            // 
            this.textBox_BEXUS_Power.Location = new System.Drawing.Point(560, 41);
            this.textBox_BEXUS_Power.Name = "textBox_BEXUS_Power";
            this.textBox_BEXUS_Power.ReadOnly = true;
            this.textBox_BEXUS_Power.Size = new System.Drawing.Size(100, 20);
            this.textBox_BEXUS_Power.TabIndex = 6;
            // 
            // textBox_EXTRA_Current
            // 
            this.textBox_EXTRA_Current.Location = new System.Drawing.Point(454, 67);
            this.textBox_EXTRA_Current.Name = "textBox_EXTRA_Current";
            this.textBox_EXTRA_Current.ReadOnly = true;
            this.textBox_EXTRA_Current.Size = new System.Drawing.Size(100, 20);
            this.textBox_EXTRA_Current.TabIndex = 5;
            // 
            // textBox_BEXUS_Current
            // 
            this.textBox_BEXUS_Current.Location = new System.Drawing.Point(454, 41);
            this.textBox_BEXUS_Current.Name = "textBox_BEXUS_Current";
            this.textBox_BEXUS_Current.ReadOnly = true;
            this.textBox_BEXUS_Current.Size = new System.Drawing.Size(100, 20);
            this.textBox_BEXUS_Current.TabIndex = 4;
            // 
            // label_EXTRA_BAT
            // 
            this.label_EXTRA_BAT.AutoSize = true;
            this.label_EXTRA_BAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EXTRA_BAT.Location = new System.Drawing.Point(225, 68);
            this.label_EXTRA_BAT.Name = "label_EXTRA_BAT";
            this.label_EXTRA_BAT.Size = new System.Drawing.Size(115, 15);
            this.label_EXTRA_BAT.TabIndex = 1;
            this.label_EXTRA_BAT.Text = "EXTRA BATTERY";
            // 
            // label_BEXUS_BAT
            // 
            this.label_BEXUS_BAT.AutoSize = true;
            this.label_BEXUS_BAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BEXUS_BAT.Location = new System.Drawing.Point(225, 42);
            this.label_BEXUS_BAT.Name = "label_BEXUS_BAT";
            this.label_BEXUS_BAT.Size = new System.Drawing.Size(117, 15);
            this.label_BEXUS_BAT.TabIndex = 0;
            this.label_BEXUS_BAT.Text = "BEXUS BATTERY";
            // 
            // textBox_EXTRA_Voltage
            // 
            this.textBox_EXTRA_Voltage.Location = new System.Drawing.Point(348, 67);
            this.textBox_EXTRA_Voltage.Name = "textBox_EXTRA_Voltage";
            this.textBox_EXTRA_Voltage.ReadOnly = true;
            this.textBox_EXTRA_Voltage.Size = new System.Drawing.Size(100, 20);
            this.textBox_EXTRA_Voltage.TabIndex = 2;
            // 
            // textBox_BEXUS_Voltage
            // 
            this.textBox_BEXUS_Voltage.Location = new System.Drawing.Point(348, 41);
            this.textBox_BEXUS_Voltage.Name = "textBox_BEXUS_Voltage";
            this.textBox_BEXUS_Voltage.ReadOnly = true;
            this.textBox_BEXUS_Voltage.Size = new System.Drawing.Size(100, 20);
            this.textBox_BEXUS_Voltage.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Voltage";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.button_valve_ambient_inside);
            this.groupBox5.Controls.Add(this.button_valve_ambient_outside);
            this.groupBox5.Controls.Add(this.button_valve_pressure_outside);
            this.groupBox5.Controls.Add(this.button_valve_pressure_inside);
            this.groupBox5.Controls.Add(this.checkBox_pneu_manual_override);
            this.groupBox5.Controls.Add(this.label_valve_ambient_outside);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label_valve_ambient_inside);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label_valve_pressure_outside);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label_valve_pressure_inside);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.textBox_PNEU_Tank);
            this.groupBox5.Controls.Add(this.textBox_PNEU_Inside_Structures);
            this.groupBox5.Controls.Add(this.textBox_PNEU_Outside_Structures);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(757, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(740, 760);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pneumatics Overview";
            // 
            // button_valve_ambient_inside
            // 
            this.button_valve_ambient_inside.Enabled = false;
            this.button_valve_ambient_inside.Location = new System.Drawing.Point(484, 494);
            this.button_valve_ambient_inside.Name = "button_valve_ambient_inside";
            this.button_valve_ambient_inside.Size = new System.Drawing.Size(93, 23);
            this.button_valve_ambient_inside.TabIndex = 21;
            this.button_valve_ambient_inside.Text = "Change Status";
            this.button_valve_ambient_inside.UseVisualStyleBackColor = true;
            // 
            // button_valve_ambient_outside
            // 
            this.button_valve_ambient_outside.Enabled = false;
            this.button_valve_ambient_outside.Location = new System.Drawing.Point(484, 137);
            this.button_valve_ambient_outside.Name = "button_valve_ambient_outside";
            this.button_valve_ambient_outside.Size = new System.Drawing.Size(93, 23);
            this.button_valve_ambient_outside.TabIndex = 20;
            this.button_valve_ambient_outside.Text = "Change Status";
            this.button_valve_ambient_outside.UseVisualStyleBackColor = true;
            // 
            // button_valve_pressure_outside
            // 
            this.button_valve_pressure_outside.Enabled = false;
            this.button_valve_pressure_outside.Location = new System.Drawing.Point(266, 266);
            this.button_valve_pressure_outside.Name = "button_valve_pressure_outside";
            this.button_valve_pressure_outside.Size = new System.Drawing.Size(93, 23);
            this.button_valve_pressure_outside.TabIndex = 20;
            this.button_valve_pressure_outside.Text = "Change Status";
            this.button_valve_pressure_outside.UseVisualStyleBackColor = true;
            // 
            // button_valve_pressure_inside
            // 
            this.button_valve_pressure_inside.Enabled = false;
            this.button_valve_pressure_inside.Location = new System.Drawing.Point(266, 621);
            this.button_valve_pressure_inside.Name = "button_valve_pressure_inside";
            this.button_valve_pressure_inside.Size = new System.Drawing.Size(93, 23);
            this.button_valve_pressure_inside.TabIndex = 19;
            this.button_valve_pressure_inside.Text = "Change Status";
            this.button_valve_pressure_inside.UseVisualStyleBackColor = true;
            // 
            // checkBox_pneu_manual_override
            // 
            this.checkBox_pneu_manual_override.AutoSize = true;
            this.checkBox_pneu_manual_override.Location = new System.Drawing.Point(65, 40);
            this.checkBox_pneu_manual_override.Name = "checkBox_pneu_manual_override";
            this.checkBox_pneu_manual_override.Size = new System.Drawing.Size(104, 17);
            this.checkBox_pneu_manual_override.TabIndex = 18;
            this.checkBox_pneu_manual_override.Text = "Manual Override";
            this.checkBox_pneu_manual_override.UseVisualStyleBackColor = true;
            this.checkBox_pneu_manual_override.CheckedChanged += new System.EventHandler(this.checkBox_pneu_manual_override_CheckedChanged);
            // 
            // label_valve_ambient_outside
            // 
            this.label_valve_ambient_outside.AutoSize = true;
            this.label_valve_ambient_outside.Location = new System.Drawing.Point(612, 70);
            this.label_valve_ambient_outside.Name = "label_valve_ambient_outside";
            this.label_valve_ambient_outside.Size = new System.Drawing.Size(33, 13);
            this.label_valve_ambient_outside.TabIndex = 17;
            this.label_valve_ambient_outside.Text = "Open";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(576, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Status:";
            // 
            // label_valve_ambient_inside
            // 
            this.label_valve_ambient_inside.AutoSize = true;
            this.label_valve_ambient_inside.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_valve_ambient_inside.Location = new System.Drawing.Point(612, 428);
            this.label_valve_ambient_inside.Name = "label_valve_ambient_inside";
            this.label_valve_ambient_inside.Size = new System.Drawing.Size(33, 13);
            this.label_valve_ambient_inside.TabIndex = 15;
            this.label_valve_ambient_inside.Text = "Open";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(576, 428);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Status:";
            // 
            // label_valve_pressure_outside
            // 
            this.label_valve_pressure_outside.AutoSize = true;
            this.label_valve_pressure_outside.Location = new System.Drawing.Point(410, 244);
            this.label_valve_pressure_outside.Name = "label_valve_pressure_outside";
            this.label_valve_pressure_outside.Size = new System.Drawing.Size(39, 13);
            this.label_valve_pressure_outside.TabIndex = 13;
            this.label_valve_pressure_outside.Text = "Closed";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Status:";
            // 
            // label_valve_pressure_inside
            // 
            this.label_valve_pressure_inside.AutoSize = true;
            this.label_valve_pressure_inside.Location = new System.Drawing.Point(410, 600);
            this.label_valve_pressure_inside.Name = "label_valve_pressure_inside";
            this.label_valve_pressure_inside.Size = new System.Drawing.Size(39, 13);
            this.label_valve_pressure_inside.TabIndex = 11;
            this.label_valve_pressure_inside.Text = "Closed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(374, 600);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tank Pressure";
            // 
            // textBox_PNEU_Tank
            // 
            this.textBox_PNEU_Tank.Location = new System.Drawing.Point(76, 207);
            this.textBox_PNEU_Tank.Name = "textBox_PNEU_Tank";
            this.textBox_PNEU_Tank.ReadOnly = true;
            this.textBox_PNEU_Tank.Size = new System.Drawing.Size(73, 20);
            this.textBox_PNEU_Tank.TabIndex = 8;
            // 
            // textBox_PNEU_Inside_Structures
            // 
            this.textBox_PNEU_Inside_Structures.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_PNEU_Inside_Structures.Location = new System.Drawing.Point(358, 450);
            this.textBox_PNEU_Inside_Structures.Name = "textBox_PNEU_Inside_Structures";
            this.textBox_PNEU_Inside_Structures.ReadOnly = true;
            this.textBox_PNEU_Inside_Structures.Size = new System.Drawing.Size(73, 20);
            this.textBox_PNEU_Inside_Structures.TabIndex = 7;
            // 
            // textBox_PNEU_Outside_Structures
            // 
            this.textBox_PNEU_Outside_Structures.Location = new System.Drawing.Point(358, 94);
            this.textBox_PNEU_Outside_Structures.Name = "textBox_PNEU_Outside_Structures";
            this.textBox_PNEU_Outside_Structures.ReadOnly = true;
            this.textBox_PNEU_Outside_Structures.Size = new System.Drawing.Size(73, 20);
            this.textBox_PNEU_Outside_Structures.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(674, 522);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 26);
            this.label20.TabIndex = 5;
            this.label20.Text = "Ambient \r\nPressure";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(674, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 26);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ambient \r\nPressure";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(355, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Outside Structures\r\nPressure\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Inside Structures\r\nPressure\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(65, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(628, 644);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tab_Ambient_Conditions
            // 
            this.tab_Ambient_Conditions.Controls.Add(this.groupBox4);
            this.tab_Ambient_Conditions.Controls.Add(this.groupBox3);
            this.tab_Ambient_Conditions.Location = new System.Drawing.Point(4, 22);
            this.tab_Ambient_Conditions.Name = "tab_Ambient_Conditions";
            this.tab_Ambient_Conditions.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ambient_Conditions.Size = new System.Drawing.Size(1505, 772);
            this.tab_Ambient_Conditions.TabIndex = 4;
            this.tab_Ambient_Conditions.Text = "Ambient Conditions";
            this.tab_Ambient_Conditions.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.chart_pressure);
            this.groupBox4.Controls.Add(this.label_amb_pres);
            this.groupBox4.Controls.Add(this.textBox_current_ambient_pressure);
            this.groupBox4.Location = new System.Drawing.Point(759, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(740, 763);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pressure";
            // 
            // chart_pressure
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_pressure.ChartAreas.Add(chartArea3);
            this.chart_pressure.Location = new System.Drawing.Point(6, 43);
            this.chart_pressure.Name = "chart_pressure";
            this.chart_pressure.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_pressure.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Pressure";
            this.chart_pressure.Series.Add(series4);
            this.chart_pressure.Size = new System.Drawing.Size(734, 717);
            this.chart_pressure.TabIndex = 4;
            this.chart_pressure.Text = "chart2";
            // 
            // label_amb_pres
            // 
            this.label_amb_pres.AutoSize = true;
            this.label_amb_pres.Location = new System.Drawing.Point(33, 23);
            this.label_amb_pres.Name = "label_amb_pres";
            this.label_amb_pres.Size = new System.Drawing.Size(85, 13);
            this.label_amb_pres.TabIndex = 1;
            this.label_amb_pres.Text = "Current Pressure";
            // 
            // textBox_current_ambient_pressure
            // 
            this.textBox_current_ambient_pressure.Location = new System.Drawing.Point(124, 20);
            this.textBox_current_ambient_pressure.Name = "textBox_current_ambient_pressure";
            this.textBox_current_ambient_pressure.ReadOnly = true;
            this.textBox_current_ambient_pressure.Size = new System.Drawing.Size(100, 20);
            this.textBox_current_ambient_pressure.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_amb_temp_2);
            this.groupBox3.Controls.Add(this.textBox_current_ambient_temperature_outside);
            this.groupBox3.Controls.Add(this.chart_temperature);
            this.groupBox3.Controls.Add(this.label_amb_temp_1);
            this.groupBox3.Controls.Add(this.textBox_current_ambient_temperature_inside);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 763);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Temperature";
            // 
            // label_amb_temp_2
            // 
            this.label_amb_temp_2.AutoSize = true;
            this.label_amb_temp_2.Location = new System.Drawing.Point(375, 23);
            this.label_amb_temp_2.Name = "label_amb_temp_2";
            this.label_amb_temp_2.Size = new System.Drawing.Size(143, 13);
            this.label_amb_temp_2.TabIndex = 5;
            this.label_amb_temp_2.Text = "Current Temperature Outside";
            // 
            // textBox_current_ambient_temperature_outside
            // 
            this.textBox_current_ambient_temperature_outside.Location = new System.Drawing.Point(524, 20);
            this.textBox_current_ambient_temperature_outside.Name = "textBox_current_ambient_temperature_outside";
            this.textBox_current_ambient_temperature_outside.ReadOnly = true;
            this.textBox_current_ambient_temperature_outside.Size = new System.Drawing.Size(100, 20);
            this.textBox_current_ambient_temperature_outside.TabIndex = 4;
            // 
            // chart_temperature
            // 
            chartArea4.BorderColor = System.Drawing.Color.DarkGray;
            chartArea4.Name = "ChartArea1";
            this.chart_temperature.ChartAreas.Add(chartArea4);
            this.chart_temperature.Location = new System.Drawing.Point(6, 43);
            this.chart_temperature.Name = "chart_temperature";
            this.chart_temperature.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_temperature.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Temperature_Inside";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Temperature_Outside";
            this.chart_temperature.Series.Add(series5);
            this.chart_temperature.Series.Add(series6);
            this.chart_temperature.Size = new System.Drawing.Size(728, 717);
            this.chart_temperature.TabIndex = 3;
            this.chart_temperature.Text = "chart1";
            // 
            // label_amb_temp_1
            // 
            this.label_amb_temp_1.AutoSize = true;
            this.label_amb_temp_1.Location = new System.Drawing.Point(45, 23);
            this.label_amb_temp_1.Name = "label_amb_temp_1";
            this.label_amb_temp_1.Size = new System.Drawing.Size(135, 13);
            this.label_amb_temp_1.TabIndex = 1;
            this.label_amb_temp_1.Text = "Current Temperature Inside";
            // 
            // textBox_current_ambient_temperature_inside
            // 
            this.textBox_current_ambient_temperature_inside.Location = new System.Drawing.Point(186, 20);
            this.textBox_current_ambient_temperature_inside.Name = "textBox_current_ambient_temperature_inside";
            this.textBox_current_ambient_temperature_inside.ReadOnly = true;
            this.textBox_current_ambient_temperature_inside.Size = new System.Drawing.Size(100, 20);
            this.textBox_current_ambient_temperature_inside.TabIndex = 0;
            // 
            // timer_ping_refresh
            // 
            this.timer_ping_refresh.Enabled = true;
            this.timer_ping_refresh.Interval = 60000;
            this.timer_ping_refresh.Tick += new System.EventHandler(this.timer_ping_refresh_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 823);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.StatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MASS Groundstation";
            this.TabControl.ResumeLayout(false);
            this.Tab_Logs.ResumeLayout(false);
            this.Tab_Logs.PerformLayout();
            this.Tab_Connection.ResumeLayout(false);
            this.Tab_Connection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ping_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TCP_PORT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UDP_PORT)).EndInit();
            this.Tab_Camera.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Tab_Experiment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tab_Ambient_Conditions.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pressure)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Button clear_log;
        private System.Windows.Forms.CheckBox enable_logging;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Tab_Logs;
        private System.Windows.Forms.TabPage Tab_Connection;
        private System.Windows.Forms.Label label_EXP_IP;
        private System.Windows.Forms.Label label_UDP_PORT;
        private System.Windows.Forms.Label label_GS_IP;
        private System.Windows.Forms.TextBox textBox_GS_IP;
        private System.Windows.Forms.TextBox textBox_EXP_IP;
        private System.Windows.Forms.Label label_TCP_PORT;
        private System.Windows.Forms.CheckBox checkBox_lock_IP_config;
        private System.Windows.Forms.Label label_PING;
        private System.Windows.Forms.NumericUpDown numericUpDown_ping_refresh;
        private System.Windows.Forms.NumericUpDown numericUpDown_TCP_PORT;
        private System.Windows.Forms.NumericUpDown numericUpDown_UDP_PORT;
        private System.Windows.Forms.Button button_connection_refresh;
        private System.Windows.Forms.Label label_sek;
        private System.Windows.Forms.Label label_PING_REFRESH;
        private System.Windows.Forms.Label label_PING_TIME;
        private System.Windows.Forms.Label label_TCP_STATUS_OUTPUT;
        private System.Windows.Forms.Label label_STATUS_TCP;
        private System.Windows.Forms.Timer timer_ping_refresh;
        private System.Windows.Forms.Label label_last_connection_refresh;
        private System.Windows.Forms.Label label_connection_last_refresh_output;
        private System.Windows.Forms.TabPage Tab_Camera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_CAM1_LOCK;
        private System.Windows.Forms.Button button_CAM1_STOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_CAM1_STATUS;
        private System.Windows.Forms.Button button_CAM1_START;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_CAM2_LOCK;
        private System.Windows.Forms.Button button_CAM2_STOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_CAM2_STATUS;
        private System.Windows.Forms.Button button_CAM2_START;
        private System.Windows.Forms.TabPage Tab_Experiment;
        private System.Windows.Forms.TabPage tab_Ambient_Conditions;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_amb_pres;
        private System.Windows.Forms.TextBox textBox_current_ambient_pressure;
        private System.Windows.Forms.Label label_amb_temp_1;
        private System.Windows.Forms.TextBox textBox_current_ambient_temperature_inside;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pressure;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_temperature;
        private System.Windows.Forms.Label label_amb_temp_2;
        private System.Windows.Forms.TextBox textBox_current_ambient_temperature_outside;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label_voltage;
        private System.Windows.Forms.TextBox textBox_BEXUS_Voltage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_EXTRA_Voltage;
        private System.Windows.Forms.Label label_BEXUS_BAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_EXTRA_Power;
        private System.Windows.Forms.TextBox textBox_BEXUS_Power;
        private System.Windows.Forms.TextBox textBox_EXTRA_Current;
        private System.Windows.Forms.TextBox textBox_BEXUS_Current;
        private System.Windows.Forms.Label label_EXTRA_BAT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_PNEU_Tank;
        private System.Windows.Forms.TextBox textBox_PNEU_Inside_Structures;
        private System.Windows.Forms.TextBox textBox_PNEU_Outside_Structures;
        private System.Windows.Forms.Label label_valve_pressure_inside;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_valve_ambient_outside;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label_valve_ambient_inside;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_valve_pressure_outside;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox_HDRM_Outside_Lock;
        private System.Windows.Forms.CheckBox checkBox_HDRM_Inside_Lock;
        private System.Windows.Forms.Button button_HDRM_Outside_Release;
        private System.Windows.Forms.Button button_HDRM_Inside_Release;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label_status_UV_ST2;
        private System.Windows.Forms.Label label_status_UV_ST1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_UV_ST2_Lock;
        private System.Windows.Forms.CheckBox checkBox_UV_ST1_Lock;
        private System.Windows.Forms.Button button_UV_ST2_OFF;
        private System.Windows.Forms.Button button_UV_ST1_OFF;
        private System.Windows.Forms.Button button_UV_ST2_ON;
        private System.Windows.Forms.Button button_UV_ST1_ON;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox checkBox_Inflation_Outside_Lock;
        private System.Windows.Forms.CheckBox checkBox_Inflation_Inside_Lock;
        private System.Windows.Forms.Button button_Inflation_Outside_Stop;
        private System.Windows.Forms.Button button_Inflation_Inside_Stop;
        private System.Windows.Forms.Button button_Inflation_Outside_Start;
        private System.Windows.Forms.Button button_Inflation_Inside_Start;
        private System.Windows.Forms.Button button_valve_ambient_inside;
        private System.Windows.Forms.Button button_valve_ambient_outside;
        private System.Windows.Forms.Button button_valve_pressure_outside;
        private System.Windows.Forms.Button button_valve_pressure_inside;
        private System.Windows.Forms.CheckBox checkBox_pneu_manual_override;
    }
}

