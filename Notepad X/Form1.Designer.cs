namespace Notepad_X
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textArea = new RichTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newFileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            exitNotepadXToolStripMenuItem = new ToolStripSeparator();
            exitNotepadXToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            creditsToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            backgroundToolStripMenuItem = new ToolStripMenuItem();
            foregroundTextToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            currentDateTimeToolStripMenuItem = new ToolStripMenuItem();
            programmingToolStripMenuItem = new ToolStripMenuItem();
            hTMLToolStripMenuItem = new ToolStripMenuItem();
            basicHTMLBoilerplateToolStripMenuItem = new ToolStripMenuItem();
            hTMLJavascriptImportToolStripMenuItem = new ToolStripMenuItem();
            hTMLCSSImToolStripMenuItem = new ToolStripMenuItem();
            tailwindExampleToolStripMenuItem = new ToolStripMenuItem();
            bootstrapExampleToolStripMenuItem = new ToolStripMenuItem();
            cSSToolStripMenuItem = new ToolStripMenuItem();
            shadowExampleToolStripMenuItem = new ToolStripMenuItem();
            divCenteringToolStripMenuItem = new ToolStripMenuItem();
            fullPageCenteringToolStripMenuItem = new ToolStripMenuItem();
            javascriptToolStripMenuItem = new ToolStripMenuItem();
            basicInputOutputExampleToolStripMenuItem4 = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            boilerplateToolStripMenuItem = new ToolStripMenuItem();
            basicInputOutputExampleToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem1 = new ToolStripMenuItem();
            basicCBoilerplateToolStripMenuItem = new ToolStripMenuItem();
            basicInputOutputExampleToolStripMenuItem1 = new ToolStripMenuItem();
            cToolStripMenuItem2 = new ToolStripMenuItem();
            basicBoilerplateToolStripMenuItem = new ToolStripMenuItem();
            basicInputOutputExampleToolStripMenuItem2 = new ToolStripMenuItem();
            pythonToolStripMenuItem = new ToolStripMenuItem();
            basicInputOutputExampleToolStripMenuItem3 = new ToolStripMenuItem();
            gUIExampleTkToolStripMenuItem = new ToolStripMenuItem();
            appExampleKivyToolStripMenuItem = new ToolStripMenuItem();
            javaToolStripMenuItem = new ToolStripMenuItem();
            basicJavaBoilerplateToolStripMenuItem = new ToolStripMenuItem();
            basicInputOutputExampleToolStripMenuItem5 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textArea
            // 
            textArea.BorderStyle = BorderStyle.FixedSingle;
            textArea.Dock = DockStyle.Fill;
            textArea.Location = new Point(0, 42);
            textArea.Name = "textArea";
            textArea.Size = new Size(1310, 1004);
            textArea.TabIndex = 0;
            textArea.Text = "";
            textArea.TextChanged += richTextBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(47, 47, 47);
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, addToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1310, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newFileToolStripMenuItem, openFileToolStripMenuItem, saveFileToolStripMenuItem, exitNotepadXToolStripMenuItem, exitNotepadXToolStripMenuItem1, toolStripMenuItem2, creditsToolStripMenuItem, formatToolStripMenuItem1 });
            fileToolStripMenuItem.ForeColor = Color.FromArgb(253, 253, 253);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 38);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // newFileToolStripMenuItem
            // 
            newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            newFileToolStripMenuItem.Size = new Size(359, 44);
            newFileToolStripMenuItem.Text = "New File";
            newFileToolStripMenuItem.Click += newFileToolStripMenuItem_Click;
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(359, 44);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(359, 44);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // exitNotepadXToolStripMenuItem
            // 
            exitNotepadXToolStripMenuItem.Name = "exitNotepadXToolStripMenuItem";
            exitNotepadXToolStripMenuItem.Size = new Size(356, 6);
            exitNotepadXToolStripMenuItem.Click += exitNotepadXToolStripMenuItem_Click;
            // 
            // exitNotepadXToolStripMenuItem1
            // 
            exitNotepadXToolStripMenuItem1.Name = "exitNotepadXToolStripMenuItem1";
            exitNotepadXToolStripMenuItem1.Size = new Size(359, 44);
            exitNotepadXToolStripMenuItem1.Text = "Exit Notepad X";
            exitNotepadXToolStripMenuItem1.Click += exitNotepadXToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(356, 6);
            // 
            // creditsToolStripMenuItem
            // 
            creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            creditsToolStripMenuItem.Size = new Size(359, 44);
            creditsToolStripMenuItem.Text = "Credits";
            creditsToolStripMenuItem.Click += creditsToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem1
            // 
            formatToolStripMenuItem1.Name = "formatToolStripMenuItem1";
            formatToolStripMenuItem1.Size = new Size(359, 44);
            formatToolStripMenuItem1.Text = "GitHub Link";
            formatToolStripMenuItem1.Click += formatToolStripMenuItem1_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripMenuItem1, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripMenuItem3, selectAllToolStripMenuItem });
            editToolStripMenuItem.ForeColor = Color.FromArgb(253, 253, 253);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(74, 38);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(242, 44);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(242, 44);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(239, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(242, 44);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(242, 44);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(242, 44);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(239, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(242, 44);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem });
            formatToolStripMenuItem.ForeColor = Color.FromArgb(253, 253, 253);
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(109, 38);
            formatToolStripMenuItem.Text = "Format";
            formatToolStripMenuItem.Click += formatToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(204, 44);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backgroundToolStripMenuItem, foregroundTextToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(204, 44);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // backgroundToolStripMenuItem
            // 
            backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            backgroundToolStripMenuItem.Size = new Size(336, 44);
            backgroundToolStripMenuItem.Text = "Background";
            backgroundToolStripMenuItem.Click += backgroundToolStripMenuItem_Click;
            // 
            // foregroundTextToolStripMenuItem
            // 
            foregroundTextToolStripMenuItem.Name = "foregroundTextToolStripMenuItem";
            foregroundTextToolStripMenuItem.Size = new Size(336, 44);
            foregroundTextToolStripMenuItem.Text = "Foreground (Text)";
            foregroundTextToolStripMenuItem.Click += foregroundTextToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentDateTimeToolStripMenuItem, programmingToolStripMenuItem });
            addToolStripMenuItem.ForeColor = Color.FromArgb(253, 253, 253);
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(77, 38);
            addToolStripMenuItem.Text = "Add";
            // 
            // currentDateTimeToolStripMenuItem
            // 
            currentDateTimeToolStripMenuItem.Name = "currentDateTimeToolStripMenuItem";
            currentDateTimeToolStripMenuItem.Size = new Size(392, 44);
            currentDateTimeToolStripMenuItem.Text = "Current Date / Time";
            currentDateTimeToolStripMenuItem.Click += currentDateTimeToolStripMenuItem_Click;
            // 
            // programmingToolStripMenuItem
            // 
            programmingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hTMLToolStripMenuItem, cSSToolStripMenuItem, javascriptToolStripMenuItem, cToolStripMenuItem, cToolStripMenuItem1, cToolStripMenuItem2, pythonToolStripMenuItem, javaToolStripMenuItem });
            programmingToolStripMenuItem.Name = "programmingToolStripMenuItem";
            programmingToolStripMenuItem.Size = new Size(392, 44);
            programmingToolStripMenuItem.Text = "Programming / Coding";
            programmingToolStripMenuItem.Click += programmingToolStripMenuItem_Click;
            // 
            // hTMLToolStripMenuItem
            // 
            hTMLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicHTMLBoilerplateToolStripMenuItem, hTMLJavascriptImportToolStripMenuItem, hTMLCSSImToolStripMenuItem, tailwindExampleToolStripMenuItem, bootstrapExampleToolStripMenuItem });
            hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            hTMLToolStripMenuItem.Size = new Size(249, 44);
            hTMLToolStripMenuItem.Text = "HTML";
            hTMLToolStripMenuItem.Click += hTMLToolStripMenuItem_Click;
            // 
            // basicHTMLBoilerplateToolStripMenuItem
            // 
            basicHTMLBoilerplateToolStripMenuItem.Name = "basicHTMLBoilerplateToolStripMenuItem";
            basicHTMLBoilerplateToolStripMenuItem.Size = new Size(420, 44);
            basicHTMLBoilerplateToolStripMenuItem.Text = "Basic HTML Boilerplate";
            basicHTMLBoilerplateToolStripMenuItem.Click += basicHTMLBoilerplateToolStripMenuItem_Click;
            // 
            // hTMLJavascriptImportToolStripMenuItem
            // 
            hTMLJavascriptImportToolStripMenuItem.Name = "hTMLJavascriptImportToolStripMenuItem";
            hTMLJavascriptImportToolStripMenuItem.Size = new Size(420, 44);
            hTMLJavascriptImportToolStripMenuItem.Text = "HTML + Javascript import";
            hTMLJavascriptImportToolStripMenuItem.Click += hTMLJavascriptImportToolStripMenuItem_Click;
            // 
            // hTMLCSSImToolStripMenuItem
            // 
            hTMLCSSImToolStripMenuItem.Name = "hTMLCSSImToolStripMenuItem";
            hTMLCSSImToolStripMenuItem.Size = new Size(420, 44);
            hTMLCSSImToolStripMenuItem.Text = "HTML + CSS Import";
            hTMLCSSImToolStripMenuItem.Click += hTMLCSSImToolStripMenuItem_Click;
            // 
            // tailwindExampleToolStripMenuItem
            // 
            tailwindExampleToolStripMenuItem.Name = "tailwindExampleToolStripMenuItem";
            tailwindExampleToolStripMenuItem.Size = new Size(420, 44);
            tailwindExampleToolStripMenuItem.Text = "Tailwind example";
            tailwindExampleToolStripMenuItem.Click += tailwindExampleToolStripMenuItem_Click;
            // 
            // bootstrapExampleToolStripMenuItem
            // 
            bootstrapExampleToolStripMenuItem.Name = "bootstrapExampleToolStripMenuItem";
            bootstrapExampleToolStripMenuItem.Size = new Size(420, 44);
            bootstrapExampleToolStripMenuItem.Text = "Bootstrap example";
            bootstrapExampleToolStripMenuItem.Click += bootstrapExampleToolStripMenuItem_Click;
            // 
            // cSSToolStripMenuItem
            // 
            cSSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shadowExampleToolStripMenuItem, divCenteringToolStripMenuItem, fullPageCenteringToolStripMenuItem });
            cSSToolStripMenuItem.Name = "cSSToolStripMenuItem";
            cSSToolStripMenuItem.Size = new Size(249, 44);
            cSSToolStripMenuItem.Text = "CSS ";
            // 
            // shadowExampleToolStripMenuItem
            // 
            shadowExampleToolStripMenuItem.Name = "shadowExampleToolStripMenuItem";
            shadowExampleToolStripMenuItem.Size = new Size(358, 44);
            shadowExampleToolStripMenuItem.Text = "Shadow example";
            shadowExampleToolStripMenuItem.Click += shadowExampleToolStripMenuItem_Click;
            // 
            // divCenteringToolStripMenuItem
            // 
            divCenteringToolStripMenuItem.Name = "divCenteringToolStripMenuItem";
            divCenteringToolStripMenuItem.Size = new Size(358, 44);
            divCenteringToolStripMenuItem.Text = "Div centering";
            divCenteringToolStripMenuItem.Click += divCenteringToolStripMenuItem_Click;
            // 
            // fullPageCenteringToolStripMenuItem
            // 
            fullPageCenteringToolStripMenuItem.Name = "fullPageCenteringToolStripMenuItem";
            fullPageCenteringToolStripMenuItem.Size = new Size(358, 44);
            fullPageCenteringToolStripMenuItem.Text = "Full-Page Centering";
            fullPageCenteringToolStripMenuItem.Click += fullPageCenteringToolStripMenuItem_Click;
            // 
            // javascriptToolStripMenuItem
            // 
            javascriptToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicInputOutputExampleToolStripMenuItem4 });
            javascriptToolStripMenuItem.Name = "javascriptToolStripMenuItem";
            javascriptToolStripMenuItem.Size = new Size(249, 44);
            javascriptToolStripMenuItem.Text = "Javascript";
            // 
            // basicInputOutputExampleToolStripMenuItem4
            // 
            basicInputOutputExampleToolStripMenuItem4.Name = "basicInputOutputExampleToolStripMenuItem4";
            basicInputOutputExampleToolStripMenuItem4.Size = new Size(458, 44);
            basicInputOutputExampleToolStripMenuItem4.Text = "Basic Input / Output Example";
            basicInputOutputExampleToolStripMenuItem4.Click += basicInputOutputExampleToolStripMenuItem4_Click;
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boilerplateToolStripMenuItem, basicInputOutputExampleToolStripMenuItem });
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(249, 44);
            cToolStripMenuItem.Text = "C";
            // 
            // boilerplateToolStripMenuItem
            // 
            boilerplateToolStripMenuItem.Name = "boilerplateToolStripMenuItem";
            boilerplateToolStripMenuItem.Size = new Size(458, 44);
            boilerplateToolStripMenuItem.Text = "Basic C Boilerplate";
            boilerplateToolStripMenuItem.Click += boilerplateToolStripMenuItem_Click;
            // 
            // basicInputOutputExampleToolStripMenuItem
            // 
            basicInputOutputExampleToolStripMenuItem.Name = "basicInputOutputExampleToolStripMenuItem";
            basicInputOutputExampleToolStripMenuItem.Size = new Size(458, 44);
            basicInputOutputExampleToolStripMenuItem.Text = "Basic Input / Output Example";
            basicInputOutputExampleToolStripMenuItem.Click += basicInputOutputExampleToolStripMenuItem_Click;
            // 
            // cToolStripMenuItem1
            // 
            cToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { basicCBoilerplateToolStripMenuItem, basicInputOutputExampleToolStripMenuItem1 });
            cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            cToolStripMenuItem1.Size = new Size(249, 44);
            cToolStripMenuItem1.Text = "C++";
            // 
            // basicCBoilerplateToolStripMenuItem
            // 
            basicCBoilerplateToolStripMenuItem.Name = "basicCBoilerplateToolStripMenuItem";
            basicCBoilerplateToolStripMenuItem.Size = new Size(458, 44);
            basicCBoilerplateToolStripMenuItem.Text = "Basic C++ Boilerplate";
            basicCBoilerplateToolStripMenuItem.Click += basicCBoilerplateToolStripMenuItem_Click;
            // 
            // basicInputOutputExampleToolStripMenuItem1
            // 
            basicInputOutputExampleToolStripMenuItem1.Name = "basicInputOutputExampleToolStripMenuItem1";
            basicInputOutputExampleToolStripMenuItem1.Size = new Size(458, 44);
            basicInputOutputExampleToolStripMenuItem1.Text = "Basic Input / Output Example";
            basicInputOutputExampleToolStripMenuItem1.Click += basicInputOutputExampleToolStripMenuItem1_Click;
            // 
            // cToolStripMenuItem2
            // 
            cToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { basicBoilerplateToolStripMenuItem, basicInputOutputExampleToolStripMenuItem2 });
            cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            cToolStripMenuItem2.Size = new Size(249, 44);
            cToolStripMenuItem2.Text = "C# ";
            // 
            // basicBoilerplateToolStripMenuItem
            // 
            basicBoilerplateToolStripMenuItem.Name = "basicBoilerplateToolStripMenuItem";
            basicBoilerplateToolStripMenuItem.Size = new Size(458, 44);
            basicBoilerplateToolStripMenuItem.Text = "Basic C# Boilerplate";
            basicBoilerplateToolStripMenuItem.Click += basicBoilerplateToolStripMenuItem_Click;
            // 
            // basicInputOutputExampleToolStripMenuItem2
            // 
            basicInputOutputExampleToolStripMenuItem2.Name = "basicInputOutputExampleToolStripMenuItem2";
            basicInputOutputExampleToolStripMenuItem2.Size = new Size(458, 44);
            basicInputOutputExampleToolStripMenuItem2.Text = "Basic Input / Output Example";
            basicInputOutputExampleToolStripMenuItem2.Click += basicInputOutputExampleToolStripMenuItem2_Click;
            // 
            // pythonToolStripMenuItem
            // 
            pythonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicInputOutputExampleToolStripMenuItem3, gUIExampleTkToolStripMenuItem, appExampleKivyToolStripMenuItem });
            pythonToolStripMenuItem.Name = "pythonToolStripMenuItem";
            pythonToolStripMenuItem.Size = new Size(249, 44);
            pythonToolStripMenuItem.Text = "Python";
            // 
            // basicInputOutputExampleToolStripMenuItem3
            // 
            basicInputOutputExampleToolStripMenuItem3.Name = "basicInputOutputExampleToolStripMenuItem3";
            basicInputOutputExampleToolStripMenuItem3.Size = new Size(458, 44);
            basicInputOutputExampleToolStripMenuItem3.Text = "Basic Input / Output Example";
            basicInputOutputExampleToolStripMenuItem3.Click += basicInputOutputExampleToolStripMenuItem3_Click;
            // 
            // gUIExampleTkToolStripMenuItem
            // 
            gUIExampleTkToolStripMenuItem.Name = "gUIExampleTkToolStripMenuItem";
            gUIExampleTkToolStripMenuItem.Size = new Size(458, 44);
            gUIExampleTkToolStripMenuItem.Text = "GUI Example (Tkinter)";
            gUIExampleTkToolStripMenuItem.Click += gUIExampleTkToolStripMenuItem_Click;
            // 
            // appExampleKivyToolStripMenuItem
            // 
            appExampleKivyToolStripMenuItem.Name = "appExampleKivyToolStripMenuItem";
            appExampleKivyToolStripMenuItem.Size = new Size(458, 44);
            appExampleKivyToolStripMenuItem.Text = "Mobile App Example (Kivy)";
            appExampleKivyToolStripMenuItem.Click += appExampleKivyToolStripMenuItem_Click;
            // 
            // javaToolStripMenuItem
            // 
            javaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicJavaBoilerplateToolStripMenuItem, basicInputOutputExampleToolStripMenuItem5 });
            javaToolStripMenuItem.Name = "javaToolStripMenuItem";
            javaToolStripMenuItem.Size = new Size(249, 44);
            javaToolStripMenuItem.Text = "Java";
            // 
            // basicJavaBoilerplateToolStripMenuItem
            // 
            basicJavaBoilerplateToolStripMenuItem.Name = "basicJavaBoilerplateToolStripMenuItem";
            basicJavaBoilerplateToolStripMenuItem.Size = new Size(458, 44);
            basicJavaBoilerplateToolStripMenuItem.Text = "Basic Java Boilerplate";
            basicJavaBoilerplateToolStripMenuItem.Click += basicJavaBoilerplateToolStripMenuItem_Click;
            // 
            // basicInputOutputExampleToolStripMenuItem5
            // 
            basicInputOutputExampleToolStripMenuItem5.Name = "basicInputOutputExampleToolStripMenuItem5";
            basicInputOutputExampleToolStripMenuItem5.Size = new Size(458, 44);
            basicInputOutputExampleToolStripMenuItem5.Text = "Basic Input / Output Example";
            basicInputOutputExampleToolStripMenuItem5.Click += basicInputOutputExampleToolStripMenuItem5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 1046);
            Controls.Add(textArea);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Notepad Z";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox textArea;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripSeparator exitNotepadXToolStripMenuItem;
        private ToolStripMenuItem exitNotepadXToolStripMenuItem1;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem currentDateTimeToolStripMenuItem;
        private ToolStripMenuItem programmingToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem foregroundTextToolStripMenuItem;
        private ToolStripMenuItem hTMLToolStripMenuItem;
        private ToolStripMenuItem cSSToolStripMenuItem;
        private ToolStripMenuItem basicHTMLBoilerplateToolStripMenuItem;
        private ToolStripMenuItem hTMLJavascriptImportToolStripMenuItem;
        private ToolStripMenuItem hTMLCSSImToolStripMenuItem;
        private ToolStripMenuItem tailwindExampleToolStripMenuItem;
        private ToolStripMenuItem bootstrapExampleToolStripMenuItem;
        private ToolStripMenuItem shadowExampleToolStripMenuItem;
        private ToolStripMenuItem divCenteringToolStripMenuItem;
        private ToolStripMenuItem fullPageCenteringToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem boilerplateToolStripMenuItem;
        private ToolStripMenuItem basicInputOutputExampleToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem basicCBoilerplateToolStripMenuItem;
        private ToolStripMenuItem basicInputOutputExampleToolStripMenuItem1;
        private ToolStripMenuItem cToolStripMenuItem2;
        private ToolStripMenuItem basicBoilerplateToolStripMenuItem;
        private ToolStripMenuItem basicInputOutputExampleToolStripMenuItem2;
        private ToolStripMenuItem pythonToolStripMenuItem;
        private ToolStripMenuItem basicInputOutputExampleToolStripMenuItem3;
        private ToolStripMenuItem gUIExampleTkToolStripMenuItem;
        private ToolStripMenuItem javascriptToolStripMenuItem;
        private ToolStripMenuItem basicInputOutputExampleToolStripMenuItem4;
        private ToolStripMenuItem appExampleKivyToolStripMenuItem;
        private ToolStripMenuItem javaToolStripMenuItem;
        private ToolStripMenuItem basicJavaBoilerplateToolStripMenuItem;
        private ToolStripMenuItem basicInputOutputExampleToolStripMenuItem5;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem creditsToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem1;
    }
}
