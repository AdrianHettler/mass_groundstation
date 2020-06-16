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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_CAM1_LOCK = new System.Windows.Forms.CheckBox();
            this.button_CAM1_STOP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CAM1_STATUS = new System.Windows.Forms.Label();
            this.button_CAM1_START = new System.Windows.Forms.Button();
            this.timer_ping_refresh = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.Tab_Logs.SuspendLayout();
            this.Tab_Connection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ping_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TCP_PORT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UDP_PORT)).BeginInit();
            this.Tab_Camera.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 801);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1513, 22);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_CAM1_LOCK);
            this.groupBox1.Controls.Add(this.button_CAM1_STOP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_CAM1_STATUS);
            this.groupBox1.Controls.Add(this.button_CAM1_START);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 72);
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
            // timer_ping_refresh
            // 
            this.timer_ping_refresh.Enabled = true;
            this.timer_ping_refresh.Interval = 60000;
            this.timer_ping_refresh.Tick += new System.EventHandler(this.timer_ping_refresh_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(576, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera 2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Lock Input";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Stop Recording";
            this.button1.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(271, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOT RECORDING";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start Recording";
            this.button2.UseVisualStyleBackColor = true;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

