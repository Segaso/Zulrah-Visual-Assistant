namespace Zulrah_Rotation_Assistant {
    partial class SettingsDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbVoiceCommandsPosition = new System.Windows.Forms.GroupBox();
            this.tlpVoiceCommandsPosition = new System.Windows.Forms.TableLayoutPanel();
            this.lblEast = new System.Windows.Forms.Label();
            this.lblSouth = new System.Windows.Forms.Label();
            this.lblWest = new System.Windows.Forms.Label();
            this.lblNorth = new System.Windows.Forms.Label();
            this.txtNorth = new System.Windows.Forms.TextBox();
            this.txtWest = new System.Windows.Forms.TextBox();
            this.txtSouth = new System.Windows.Forms.TextBox();
            this.txtEast = new System.Windows.Forms.TextBox();
            this.gbVoiceCommandsStyle = new System.Windows.Forms.GroupBox();
            this.tlpVoiceCommandsStyle = new System.Windows.Forms.TableLayoutPanel();
            this.txtRanged = new System.Windows.Forms.TextBox();
            this.lblRanged = new System.Windows.Forms.Label();
            this.txtMelee = new System.Windows.Forms.TextBox();
            this.lblMelee = new System.Windows.Forms.Label();
            this.txtMage = new System.Windows.Forms.TextBox();
            this.lblMage = new System.Windows.Forms.Label();
            this.gbMapSettings = new System.Windows.Forms.GroupBox();
            this.tlpMapSetting = new System.Windows.Forms.TableLayoutPanel();
            this.pnMeleeColor = new System.Windows.Forms.Panel();
            this.pnMageColor = new System.Windows.Forms.Panel();
            this.pnRangeColor = new System.Windows.Forms.Panel();
            this.pnMapColor = new System.Windows.Forms.Panel();
            this.pnZulrahColor = new System.Windows.Forms.Panel();
            this.pnJadColor = new System.Windows.Forms.Panel();
            this.lblMapOrientation = new System.Windows.Forms.Label();
            this.lblJadColor = new System.Windows.Forms.Label();
            this.lblRangeColor = new System.Windows.Forms.Label();
            this.lblMageColor = new System.Windows.Forms.Label();
            this.lblMeleeColor = new System.Windows.Forms.Label();
            this.chkFlipMap = new System.Windows.Forms.CheckBox();
            this.lblZulrahIslandColor = new System.Windows.Forms.Label();
            this.lblMapBackgroundColor = new System.Windows.Forms.Label();
            this.tlpVoiceCommandsGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.txtNext = new System.Windows.Forms.TextBox();
            this.txtReset = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.gbVoiceCommandsGeneral = new System.Windows.Forms.GroupBox();
            this.gbVoiceCommandsPosition.SuspendLayout();
            this.tlpVoiceCommandsPosition.SuspendLayout();
            this.gbVoiceCommandsStyle.SuspendLayout();
            this.tlpVoiceCommandsStyle.SuspendLayout();
            this.gbMapSettings.SuspendLayout();
            this.tlpMapSetting.SuspendLayout();
            this.tlpVoiceCommandsGeneral.SuspendLayout();
            this.gbVoiceCommandsGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 578);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 578);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbVoiceCommandsPosition
            // 
            this.gbVoiceCommandsPosition.Controls.Add(this.tlpVoiceCommandsPosition);
            this.gbVoiceCommandsPosition.Location = new System.Drawing.Point(12, 344);
            this.gbVoiceCommandsPosition.Name = "gbVoiceCommandsPosition";
            this.gbVoiceCommandsPosition.Size = new System.Drawing.Size(306, 124);
            this.gbVoiceCommandsPosition.TabIndex = 5;
            this.gbVoiceCommandsPosition.TabStop = false;
            this.gbVoiceCommandsPosition.Text = "Voice Commands - Position";
            // 
            // tlpVoiceCommandsPosition
            // 
            this.tlpVoiceCommandsPosition.ColumnCount = 2;
            this.tlpVoiceCommandsPosition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVoiceCommandsPosition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVoiceCommandsPosition.Controls.Add(this.lblEast, 0, 3);
            this.tlpVoiceCommandsPosition.Controls.Add(this.lblSouth, 0, 2);
            this.tlpVoiceCommandsPosition.Controls.Add(this.lblWest, 0, 1);
            this.tlpVoiceCommandsPosition.Controls.Add(this.lblNorth, 0, 0);
            this.tlpVoiceCommandsPosition.Controls.Add(this.txtNorth, 1, 0);
            this.tlpVoiceCommandsPosition.Controls.Add(this.txtWest, 1, 1);
            this.tlpVoiceCommandsPosition.Controls.Add(this.txtSouth, 1, 2);
            this.tlpVoiceCommandsPosition.Controls.Add(this.txtEast, 1, 3);
            this.tlpVoiceCommandsPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVoiceCommandsPosition.Location = new System.Drawing.Point(3, 16);
            this.tlpVoiceCommandsPosition.Name = "tlpVoiceCommandsPosition";
            this.tlpVoiceCommandsPosition.RowCount = 5;
            this.tlpVoiceCommandsPosition.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVoiceCommandsPosition.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVoiceCommandsPosition.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVoiceCommandsPosition.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVoiceCommandsPosition.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVoiceCommandsPosition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVoiceCommandsPosition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVoiceCommandsPosition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVoiceCommandsPosition.Size = new System.Drawing.Size(300, 105);
            this.tlpVoiceCommandsPosition.TabIndex = 0;
            // 
            // lblEast
            // 
            this.lblEast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEast.AutoSize = true;
            this.lblEast.Location = new System.Drawing.Point(3, 84);
            this.lblEast.Name = "lblEast";
            this.lblEast.Size = new System.Drawing.Size(28, 13);
            this.lblEast.TabIndex = 11;
            this.lblEast.Text = "East";
            // 
            // lblSouth
            // 
            this.lblSouth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSouth.AutoSize = true;
            this.lblSouth.Location = new System.Drawing.Point(3, 58);
            this.lblSouth.Name = "lblSouth";
            this.lblSouth.Size = new System.Drawing.Size(35, 13);
            this.lblSouth.TabIndex = 9;
            this.lblSouth.Text = "South";
            // 
            // lblWest
            // 
            this.lblWest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWest.AutoSize = true;
            this.lblWest.Location = new System.Drawing.Point(3, 32);
            this.lblWest.Name = "lblWest";
            this.lblWest.Size = new System.Drawing.Size(32, 13);
            this.lblWest.TabIndex = 7;
            this.lblWest.Text = "West";
            // 
            // lblNorth
            // 
            this.lblNorth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNorth.AutoSize = true;
            this.lblNorth.Location = new System.Drawing.Point(3, 6);
            this.lblNorth.Name = "lblNorth";
            this.lblNorth.Size = new System.Drawing.Size(33, 13);
            this.lblNorth.TabIndex = 5;
            this.lblNorth.Text = "North";
            // 
            // txtNorth
            // 
            this.txtNorth.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "NorthPositionVoiceCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNorth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNorth.Location = new System.Drawing.Point(44, 3);
            this.txtNorth.Name = "txtNorth";
            this.txtNorth.Size = new System.Drawing.Size(253, 20);
            this.txtNorth.TabIndex = 6;
            this.txtNorth.Text = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.NorthPositionVoiceCommand;
            // 
            // txtWest
            // 
            this.txtWest.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "WestPositionVoiceCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWest.Location = new System.Drawing.Point(44, 29);
            this.txtWest.Name = "txtWest";
            this.txtWest.Size = new System.Drawing.Size(253, 20);
            this.txtWest.TabIndex = 8;
            this.txtWest.Text = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.WestPositionVoiceCommand;
            // 
            // txtSouth
            // 
            this.txtSouth.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "SouthPositionVoiceCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSouth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSouth.Location = new System.Drawing.Point(44, 55);
            this.txtSouth.Name = "txtSouth";
            this.txtSouth.Size = new System.Drawing.Size(253, 20);
            this.txtSouth.TabIndex = 10;
            this.txtSouth.Text = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.SouthPositionVoiceCommand;
            // 
            // txtEast
            // 
            this.txtEast.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "EastPositionVoiceCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtEast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEast.Location = new System.Drawing.Point(44, 81);
            this.txtEast.Name = "txtEast";
            this.txtEast.Size = new System.Drawing.Size(253, 20);
            this.txtEast.TabIndex = 12;
            this.txtEast.Text = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.EastPositionVoiceCommand;
            // 
            // gbVoiceCommandsStyle
            // 
            this.gbVoiceCommandsStyle.Controls.Add(this.tlpVoiceCommandsStyle);
            this.gbVoiceCommandsStyle.Location = new System.Drawing.Point(12, 474);
            this.gbVoiceCommandsStyle.Name = "gbVoiceCommandsStyle";
            this.gbVoiceCommandsStyle.Size = new System.Drawing.Size(306, 98);
            this.gbVoiceCommandsStyle.TabIndex = 6;
            this.gbVoiceCommandsStyle.TabStop = false;
            this.gbVoiceCommandsStyle.Text = "Voice Commands - Style";
            // 
            // tlpVoiceCommandsStyle
            // 
            this.tlpVoiceCommandsStyle.ColumnCount = 2;
            this.tlpVoiceCommandsStyle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVoiceCommandsStyle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVoiceCommandsStyle.Controls.Add(this.txtRanged, 1, 2);
            this.tlpVoiceCommandsStyle.Controls.Add(this.lblRanged, 0, 2);
            this.tlpVoiceCommandsStyle.Controls.Add(this.txtMelee, 1, 1);
            this.tlpVoiceCommandsStyle.Controls.Add(this.lblMelee, 0, 1);
            this.tlpVoiceCommandsStyle.Controls.Add(this.txtMage, 1, 0);
            this.tlpVoiceCommandsStyle.Controls.Add(this.lblMage, 0, 0);
            this.tlpVoiceCommandsStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVoiceCommandsStyle.Location = new System.Drawing.Point(3, 16);
            this.tlpVoiceCommandsStyle.Name = "tlpVoiceCommandsStyle";
            this.tlpVoiceCommandsStyle.RowCount = 3;
            this.tlpVoiceCommandsStyle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVoiceCommandsStyle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVoiceCommandsStyle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVoiceCommandsStyle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVoiceCommandsStyle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVoiceCommandsStyle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVoiceCommandsStyle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVoiceCommandsStyle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVoiceCommandsStyle.Size = new System.Drawing.Size(300, 79);
            this.tlpVoiceCommandsStyle.TabIndex = 0;
            // 
            // txtRanged
            // 
            this.txtRanged.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "RangeVoiceCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRanged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRanged.Location = new System.Drawing.Point(54, 55);
            this.txtRanged.Name = "txtRanged";
            this.txtRanged.Size = new System.Drawing.Size(243, 20);
            this.txtRanged.TabIndex = 5;
            this.txtRanged.Text = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.RangeVoiceCommand;
            // 
            // lblRanged
            // 
            this.lblRanged.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRanged.AutoSize = true;
            this.lblRanged.Location = new System.Drawing.Point(3, 59);
            this.lblRanged.Name = "lblRanged";
            this.lblRanged.Size = new System.Drawing.Size(45, 13);
            this.lblRanged.TabIndex = 4;
            this.lblRanged.Text = "Ranged";
            // 
            // txtMelee
            // 
            this.txtMelee.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "MeleeVoiceCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMelee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMelee.Location = new System.Drawing.Point(54, 29);
            this.txtMelee.Name = "txtMelee";
            this.txtMelee.Size = new System.Drawing.Size(243, 20);
            this.txtMelee.TabIndex = 3;
            this.txtMelee.Text = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.MeleeVoiceCommand;
            // 
            // lblMelee
            // 
            this.lblMelee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMelee.AutoSize = true;
            this.lblMelee.Location = new System.Drawing.Point(3, 32);
            this.lblMelee.Name = "lblMelee";
            this.lblMelee.Size = new System.Drawing.Size(36, 13);
            this.lblMelee.TabIndex = 2;
            this.lblMelee.Text = "Melee";
            // 
            // txtMage
            // 
            this.txtMage.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "MageVoiceCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMage.Location = new System.Drawing.Point(54, 3);
            this.txtMage.Name = "txtMage";
            this.txtMage.Size = new System.Drawing.Size(243, 20);
            this.txtMage.TabIndex = 0;
            this.txtMage.Text = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.MageVoiceCommand;
            // 
            // lblMage
            // 
            this.lblMage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMage.AutoSize = true;
            this.lblMage.Location = new System.Drawing.Point(3, 6);
            this.lblMage.Name = "lblMage";
            this.lblMage.Size = new System.Drawing.Size(34, 13);
            this.lblMage.TabIndex = 1;
            this.lblMage.Text = "Mage";
            this.lblMage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbMapSettings
            // 
            this.gbMapSettings.Controls.Add(this.tlpMapSetting);
            this.gbMapSettings.Location = new System.Drawing.Point(12, 12);
            this.gbMapSettings.Name = "gbMapSettings";
            this.gbMapSettings.Size = new System.Drawing.Size(306, 186);
            this.gbMapSettings.TabIndex = 8;
            this.gbMapSettings.TabStop = false;
            this.gbMapSettings.Text = "Map Settings";
            // 
            // tlpMapSetting
            // 
            this.tlpMapSetting.ColumnCount = 2;
            this.tlpMapSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMapSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMapSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMapSetting.Controls.Add(this.pnMeleeColor, 1, 1);
            this.tlpMapSetting.Controls.Add(this.pnMageColor, 1, 3);
            this.tlpMapSetting.Controls.Add(this.pnRangeColor, 1, 4);
            this.tlpMapSetting.Controls.Add(this.pnMapColor, 1, 7);
            this.tlpMapSetting.Controls.Add(this.pnZulrahColor, 1, 6);
            this.tlpMapSetting.Controls.Add(this.pnJadColor, 1, 5);
            this.tlpMapSetting.Controls.Add(this.lblMapOrientation, 0, 0);
            this.tlpMapSetting.Controls.Add(this.lblJadColor, 0, 5);
            this.tlpMapSetting.Controls.Add(this.lblRangeColor, 0, 4);
            this.tlpMapSetting.Controls.Add(this.lblMageColor, 0, 3);
            this.tlpMapSetting.Controls.Add(this.lblMeleeColor, 0, 1);
            this.tlpMapSetting.Controls.Add(this.chkFlipMap, 1, 0);
            this.tlpMapSetting.Controls.Add(this.lblZulrahIslandColor, 0, 6);
            this.tlpMapSetting.Controls.Add(this.lblMapBackgroundColor, 0, 7);
            this.tlpMapSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMapSetting.Location = new System.Drawing.Point(3, 16);
            this.tlpMapSetting.Name = "tlpMapSetting";
            this.tlpMapSetting.RowCount = 9;
            this.tlpMapSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMapSetting.Size = new System.Drawing.Size(300, 167);
            this.tlpMapSetting.TabIndex = 0;
            // 
            // pnMeleeColor
            // 
            this.pnMeleeColor.AutoSize = true;
            this.pnMeleeColor.BackColor = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.MeleeColor;
            this.pnMeleeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMeleeColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "MeleeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnMeleeColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMeleeColor.Location = new System.Drawing.Point(125, 26);
            this.pnMeleeColor.Name = "pnMeleeColor";
            this.pnMeleeColor.Padding = new System.Windows.Forms.Padding(8);
            this.pnMeleeColor.Size = new System.Drawing.Size(172, 18);
            this.pnMeleeColor.TabIndex = 6;
            this.pnMeleeColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseClick);
            // 
            // pnMageColor
            // 
            this.pnMageColor.AutoSize = true;
            this.pnMageColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnMageColor.BackColor = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.MageColor;
            this.pnMageColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMageColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "MageColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnMageColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMageColor.Location = new System.Drawing.Point(125, 50);
            this.pnMageColor.Name = "pnMageColor";
            this.pnMageColor.Padding = new System.Windows.Forms.Padding(8);
            this.pnMageColor.Size = new System.Drawing.Size(172, 18);
            this.pnMageColor.TabIndex = 7;
            this.pnMageColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseClick);
            // 
            // pnRangeColor
            // 
            this.pnRangeColor.AutoSize = true;
            this.pnRangeColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnRangeColor.BackColor = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.RangeColor;
            this.pnRangeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnRangeColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "RangeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnRangeColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRangeColor.Location = new System.Drawing.Point(125, 74);
            this.pnRangeColor.Name = "pnRangeColor";
            this.pnRangeColor.Padding = new System.Windows.Forms.Padding(8);
            this.pnRangeColor.Size = new System.Drawing.Size(172, 18);
            this.pnRangeColor.TabIndex = 8;
            this.pnRangeColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseClick);
            // 
            // pnMapColor
            // 
            this.pnMapColor.AutoSize = true;
            this.pnMapColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnMapColor.BackColor = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.MapBackgroundColor;
            this.pnMapColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMapColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "MapBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnMapColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMapColor.Location = new System.Drawing.Point(125, 146);
            this.pnMapColor.Name = "pnMapColor";
            this.pnMapColor.Padding = new System.Windows.Forms.Padding(8);
            this.pnMapColor.Size = new System.Drawing.Size(172, 18);
            this.pnMapColor.TabIndex = 13;
            this.pnMapColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseClick);
            // 
            // pnZulrahColor
            // 
            this.pnZulrahColor.AutoSize = true;
            this.pnZulrahColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnZulrahColor.BackColor = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.ZulrahIsland_BorderColor;
            this.pnZulrahColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnZulrahColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "ZulrahIsland_BorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnZulrahColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnZulrahColor.Location = new System.Drawing.Point(125, 122);
            this.pnZulrahColor.Name = "pnZulrahColor";
            this.pnZulrahColor.Padding = new System.Windows.Forms.Padding(8);
            this.pnZulrahColor.Size = new System.Drawing.Size(172, 18);
            this.pnZulrahColor.TabIndex = 11;
            this.pnZulrahColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseClick);
            // 
            // pnJadColor
            // 
            this.pnJadColor.AutoSize = true;
            this.pnJadColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnJadColor.BackColor = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.JadColor;
            this.pnJadColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnJadColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "JadColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnJadColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnJadColor.Location = new System.Drawing.Point(125, 98);
            this.pnJadColor.Name = "pnJadColor";
            this.pnJadColor.Padding = new System.Windows.Forms.Padding(8);
            this.pnJadColor.Size = new System.Drawing.Size(172, 18);
            this.pnJadColor.TabIndex = 9;
            this.pnJadColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColor_MouseClick);
            // 
            // lblMapOrientation
            // 
            this.lblMapOrientation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMapOrientation.AutoSize = true;
            this.lblMapOrientation.Location = new System.Drawing.Point(3, 5);
            this.lblMapOrientation.Name = "lblMapOrientation";
            this.lblMapOrientation.Size = new System.Drawing.Size(82, 13);
            this.lblMapOrientation.TabIndex = 5;
            this.lblMapOrientation.Text = "Map Orientation";
            this.lblMapOrientation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJadColor
            // 
            this.lblJadColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblJadColor.AutoSize = true;
            this.lblJadColor.Location = new System.Drawing.Point(3, 100);
            this.lblJadColor.Name = "lblJadColor";
            this.lblJadColor.Size = new System.Drawing.Size(51, 13);
            this.lblJadColor.TabIndex = 4;
            this.lblJadColor.Text = "Jad Color";
            this.lblJadColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRangeColor
            // 
            this.lblRangeColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRangeColor.AutoSize = true;
            this.lblRangeColor.Location = new System.Drawing.Point(3, 76);
            this.lblRangeColor.Name = "lblRangeColor";
            this.lblRangeColor.Size = new System.Drawing.Size(66, 13);
            this.lblRangeColor.TabIndex = 3;
            this.lblRangeColor.Text = "Range Color";
            this.lblRangeColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMageColor
            // 
            this.lblMageColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMageColor.AutoSize = true;
            this.lblMageColor.Location = new System.Drawing.Point(3, 52);
            this.lblMageColor.Name = "lblMageColor";
            this.lblMageColor.Size = new System.Drawing.Size(61, 13);
            this.lblMageColor.TabIndex = 2;
            this.lblMageColor.Text = "Mage Color";
            this.lblMageColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMeleeColor
            // 
            this.lblMeleeColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMeleeColor.AutoSize = true;
            this.lblMeleeColor.Location = new System.Drawing.Point(3, 28);
            this.lblMeleeColor.Name = "lblMeleeColor";
            this.lblMeleeColor.Size = new System.Drawing.Size(63, 13);
            this.lblMeleeColor.TabIndex = 1;
            this.lblMeleeColor.Text = "Melee Color";
            this.lblMeleeColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkFlipMap
            // 
            this.chkFlipMap.AutoSize = true;
            this.chkFlipMap.Checked = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.MapFlipped;
            this.chkFlipMap.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "MapFlipped", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkFlipMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFlipMap.Location = new System.Drawing.Point(125, 3);
            this.chkFlipMap.Name = "chkFlipMap";
            this.chkFlipMap.Size = new System.Drawing.Size(172, 17);
            this.chkFlipMap.TabIndex = 3;
            this.chkFlipMap.Text = "Flip Map";
            this.chkFlipMap.UseVisualStyleBackColor = true;
            // 
            // lblZulrahIslandColor
            // 
            this.lblZulrahIslandColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblZulrahIslandColor.AutoSize = true;
            this.lblZulrahIslandColor.Location = new System.Drawing.Point(3, 124);
            this.lblZulrahIslandColor.Name = "lblZulrahIslandColor";
            this.lblZulrahIslandColor.Size = new System.Drawing.Size(95, 13);
            this.lblZulrahIslandColor.TabIndex = 10;
            this.lblZulrahIslandColor.Text = "Zulrah Island Color";
            this.lblZulrahIslandColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMapBackgroundColor
            // 
            this.lblMapBackgroundColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMapBackgroundColor.AutoSize = true;
            this.lblMapBackgroundColor.Location = new System.Drawing.Point(3, 148);
            this.lblMapBackgroundColor.Name = "lblMapBackgroundColor";
            this.lblMapBackgroundColor.Size = new System.Drawing.Size(116, 13);
            this.lblMapBackgroundColor.TabIndex = 12;
            this.lblMapBackgroundColor.Text = "Map Background Color";
            this.lblMapBackgroundColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpVoiceCommandsGeneral
            // 
            this.tlpVoiceCommandsGeneral.ColumnCount = 2;
            this.tlpVoiceCommandsGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVoiceCommandsGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVoiceCommandsGeneral.Controls.Add(this.label1, 0, 3);
            this.tlpVoiceCommandsGeneral.Controls.Add(this.lblPrevious, 0, 2);
            this.tlpVoiceCommandsGeneral.Controls.Add(this.lblReset, 0, 1);
            this.tlpVoiceCommandsGeneral.Controls.Add(this.lblNext, 0, 0);
            this.tlpVoiceCommandsGeneral.Controls.Add(this.txtNext, 1, 0);
            this.tlpVoiceCommandsGeneral.Controls.Add(this.txtReset, 1, 1);
            this.tlpVoiceCommandsGeneral.Controls.Add(this.txtPrevious, 1, 2);
            this.tlpVoiceCommandsGeneral.Controls.Add(this.txtResume, 1, 3);
            this.tlpVoiceCommandsGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVoiceCommandsGeneral.Location = new System.Drawing.Point(3, 16);
            this.tlpVoiceCommandsGeneral.Name = "tlpVoiceCommandsGeneral";
            this.tlpVoiceCommandsGeneral.RowCount = 4;
            this.tlpVoiceCommandsGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVoiceCommandsGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVoiceCommandsGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVoiceCommandsGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVoiceCommandsGeneral.Size = new System.Drawing.Size(300, 104);
            this.tlpVoiceCommandsGeneral.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resume";
            // 
            // lblPrevious
            // 
            this.lblPrevious.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Location = new System.Drawing.Point(3, 58);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(37, 13);
            this.lblPrevious.TabIndex = 7;
            this.lblPrevious.Text = "Pause";
            // 
            // lblReset
            // 
            this.lblReset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReset.AutoSize = true;
            this.lblReset.Location = new System.Drawing.Point(3, 32);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(35, 13);
            this.lblReset.TabIndex = 3;
            this.lblReset.Text = "Reset";
            // 
            // lblNext
            // 
            this.lblNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(3, 6);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(29, 13);
            this.lblNext.TabIndex = 1;
            this.lblNext.Text = "Next";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNext
            // 
            this.txtNext.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "NextVoiceCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNext.Location = new System.Drawing.Point(55, 3);
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(242, 20);
            this.txtNext.TabIndex = 4;
            this.txtNext.Text = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.NextVoiceCommand;
            // 
            // txtReset
            // 
            this.txtReset.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "ResetVoiceCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReset.Location = new System.Drawing.Point(55, 29);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(242, 20);
            this.txtReset.TabIndex = 5;
            this.txtReset.Text = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.ResetVoiceCommand;
            // 
            // txtPrevious
            // 
            this.txtPrevious.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "PauseVoiceCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrevious.Location = new System.Drawing.Point(55, 55);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(242, 20);
            this.txtPrevious.TabIndex = 6;
            this.txtPrevious.Text = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.PauseVoiceCommand;
            // 
            // txtResume
            // 
            this.txtResume.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Zulrah_Rotation_Assistant.Properties.Settings.Default, "ResumeVoiceCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtResume.Location = new System.Drawing.Point(55, 81);
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(240, 20);
            this.txtResume.TabIndex = 9;
            this.txtResume.Text = global::Zulrah_Rotation_Assistant.Properties.Settings.Default.ResumeVoiceCommand;
            // 
            // gbVoiceCommandsGeneral
            // 
            this.gbVoiceCommandsGeneral.Controls.Add(this.tlpVoiceCommandsGeneral);
            this.gbVoiceCommandsGeneral.Location = new System.Drawing.Point(12, 204);
            this.gbVoiceCommandsGeneral.Name = "gbVoiceCommandsGeneral";
            this.gbVoiceCommandsGeneral.Size = new System.Drawing.Size(306, 123);
            this.gbVoiceCommandsGeneral.TabIndex = 7;
            this.gbVoiceCommandsGeneral.TabStop = false;
            this.gbVoiceCommandsGeneral.Text = "Voice Commands - General";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 609);
            this.Controls.Add(this.gbMapSettings);
            this.Controls.Add(this.gbVoiceCommandsGeneral);
            this.Controls.Add(this.gbVoiceCommandsStyle);
            this.Controls.Add(this.gbVoiceCommandsPosition);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zulrah Rotation Assistant Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsDialog_FormClosed);
            this.gbVoiceCommandsPosition.ResumeLayout(false);
            this.tlpVoiceCommandsPosition.ResumeLayout(false);
            this.tlpVoiceCommandsPosition.PerformLayout();
            this.gbVoiceCommandsStyle.ResumeLayout(false);
            this.tlpVoiceCommandsStyle.ResumeLayout(false);
            this.tlpVoiceCommandsStyle.PerformLayout();
            this.gbMapSettings.ResumeLayout(false);
            this.tlpMapSetting.ResumeLayout(false);
            this.tlpMapSetting.PerformLayout();
            this.tlpVoiceCommandsGeneral.ResumeLayout(false);
            this.tlpVoiceCommandsGeneral.PerformLayout();
            this.gbVoiceCommandsGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkFlipMap;
        private System.Windows.Forms.GroupBox gbVoiceCommandsPosition;
        private System.Windows.Forms.TableLayoutPanel tlpVoiceCommandsPosition;
        private System.Windows.Forms.Label lblEast;
        private System.Windows.Forms.Label lblSouth;
        private System.Windows.Forms.Label lblWest;
        private System.Windows.Forms.Label lblNorth;
        private System.Windows.Forms.TextBox txtNorth;
        private System.Windows.Forms.TextBox txtWest;
        private System.Windows.Forms.TextBox txtSouth;
        private System.Windows.Forms.TextBox txtEast;
        private System.Windows.Forms.GroupBox gbVoiceCommandsStyle;
        private System.Windows.Forms.TableLayoutPanel tlpVoiceCommandsStyle;
        private System.Windows.Forms.TextBox txtRanged;
        private System.Windows.Forms.Label lblRanged;
        private System.Windows.Forms.TextBox txtMelee;
        private System.Windows.Forms.Label lblMelee;
        private System.Windows.Forms.TextBox txtMage;
        private System.Windows.Forms.Label lblMage;
        private System.Windows.Forms.GroupBox gbMapSettings;
        private System.Windows.Forms.TableLayoutPanel tlpMapSetting;
        private System.Windows.Forms.Label lblMapOrientation;
        private System.Windows.Forms.Label lblJadColor;
        private System.Windows.Forms.Label lblRangeColor;
        private System.Windows.Forms.Label lblMageColor;
        private System.Windows.Forms.Label lblMeleeColor;
        private System.Windows.Forms.TableLayoutPanel tlpVoiceCommandsGeneral;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.TextBox txtNext;
        private System.Windows.Forms.TextBox txtReset;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.GroupBox gbVoiceCommandsGeneral;
        private System.Windows.Forms.Panel pnJadColor;
        private System.Windows.Forms.Panel pnMageColor;
        private System.Windows.Forms.Panel pnRangeColor;
        private System.Windows.Forms.Label lblZulrahIslandColor;
        private System.Windows.Forms.Panel pnZulrahColor;
        private System.Windows.Forms.Label lblMapBackgroundColor;
        private System.Windows.Forms.Panel pnMapColor;
        private System.Windows.Forms.Panel pnMeleeColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResume;
    }
}