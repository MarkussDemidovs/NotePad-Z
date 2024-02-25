using System.Diagnostics;

namespace Notepad_X
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void exitNotepadXToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.SelectAll();
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Clear();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opener = new OpenFileDialog();
            opener.Title = "Open file";
            opener.Filter = "Text Document (*.txt)|*.txt|All files (*.*)|*.*";

            if (opener.ShowDialog() == DialogResult.OK)
            {
                textArea.LoadFile(opener.FileName, RichTextBoxStreamType.PlainText);
                this.Text = opener.FileName;
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog opener = new SaveFileDialog();
            opener.Title = "Save file";
            opener.Filter = "Text Document (*.txt)|*.txt|All files (*.*)|*.*";

            if (opener.ShowDialog() == DialogResult.OK)
            {
                textArea.SaveFile(opener.FileName, RichTextBoxStreamType.PlainText);
                this.Text = opener.FileName;
            }
        }

        private void exitNotepadXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void currentDateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = System.DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Paste();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontSelect = new FontDialog();
            if (fontSelect.ShowDialog() == DialogResult.OK)
            {
                textArea.Font = fontSelect.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void foregroundTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorSelect = new ColorDialog();
            if (colorSelect.ShowDialog() == DialogResult.OK)
            {
                textArea.ForeColor = colorSelect.Color;
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorSelect = new ColorDialog();
            if (colorSelect.ShowDialog() == DialogResult.OK)
            {
                textArea.BackColor = colorSelect.Color;
            }
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programmingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hTMLCSSImToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n  <head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>HTML 5 Boilerplate</title>\r\n    <link rel=\"stylesheet\" href=\"style.css\">\r\n  </head>\r\n  <body>\r\n\t<script src=\"index.js\"></script>\r\n  </body>\r\n</html>";
        }

        private void basicBoilerplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "using System;\r\n\r\nnamespace MyApp\r\n{\r\n    internal class Program\r\n    {\r\n        static void Main(string[] args)\r\n        {\r\n            Console.WriteLine(\"Hello, World!\");\r\n        }\r\n    }\r\n}\r\n";
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/MarkussDemidovs/NotePad-Z/tree/main");
            Process.Start(sInfo);

        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 credits = new Form2();
            credits.Show();
        }

        private void basicHTMLBoilerplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n  <head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>HTML 5 Boilerplate</title>\r\n  </head>\r\n  <body>\r\n\t\r\n  </body>\r\n</html>";

        }

        private void hTMLJavascriptImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n  <head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>HTML 5 Boilerplate</title>\r\n    </head>\r\n  <body>\r\n\t<script src=\"index.js\"></script>\r\n  </body>\r\n</html>";
        }

        private void tailwindExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "<!doctype html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <script src=\"https://cdn.tailwindcss.com\"></script>\r\n    <title>Your Awesome Project</title>\r\n</head>\r\n<body>\r\n    <!-- Your content goes here -->\r\n    <h1 class=\"text-3xl font-bold underline\">Hello, World!</h1>\r\n    <!-- Add more HTML elements as needed -->\r\n</body>\r\n</html>\r\n";
        }

        private void bootstrapExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "<!doctype html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">\r\n    <title>Hello, world!</title>\r\n</head>\r\n<body>\r\n    <h1>Hello, world!</h1>\r\n    <!-- Add more HTML elements as needed -->\r\n</body>\r\n</html>\r\n";
        }

        private void shadowExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "*\n{\nbox-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;\n}";
        }

        private void divCenteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = ".center {\r\n  margin: auto;\r\n  width: 50%;\r\n  border: 3px solid green;\r\n  padding: 10px;\r\n}";
        }

        private void fullPageCenteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = ".content {\r\n  max-width: 500px;\r\n  margin: auto;\r\n}\r\n";
        }

        private void basicInputOutputExampleToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            textArea.Text = "  // Creates <input id=\"myTextBox\" type=\"text\" />\r\n  var textBox = document.createElement(\"input\");\r\n  textBox.id = \"myTextBox\";\r\n  textBox.type = \"text\";\r\n\r\n  // Creates <button id=\"myButton\" type=\"button\">Show</button>\r\n  var btnShow = document.createElement(\"button\");\r\n  btnShow.id = \"myButton\";\r\n  btnShow.type = \"button\";\r\n  btnShow.innerHTML = \"Show\";\r\n\r\n  // When you click in the button, show the message.\r\n  btnShow.onclick = function showMessage() {\r\n    alert(\"Hello \" + textBox.value + \"!\");\r\n  };\r\n\r\n  // Add created elements.\r\n  document.body.appendChild(textBox);\r\n  document.body.appendChild(btnShow);\r\n\r\n";
        }

        private void boilerplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "#include <stdio.h>\r\n\r\nint main() {\r\n    printf(\"Hello, world!\\n\");\r\n    return 0;\r\n}\r\n";
        }

        private void basicInputOutputExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "// C program to show input and output\r\n\r\n#include <stdio.h>\r\n\r\nint main()\r\n{\r\n\r\n\t// Declare string variable\r\n\t// as character array\r\n\tchar str[50];\r\n\r\n\t// --- String ---\r\n\t// To read a word\r\n\r\n\t// Input the Word\r\n\tprintf(\"Enter the Word: \");\r\n\tscanf(\"%s\\n\", str);\r\n\r\n\t// Output the Word\r\n\tprintf(\"\\nEntered Word is: %s\", str);\r\n\r\n\t// --- String ---\r\n\t// To read a Sentence\r\n\r\n\t// Input the Sentence\r\n\tprintf(\"\\n\\nEnter the Sentence: \");\r\n\tscanf(\"%[^\\n]\\ns\", str);\r\n\r\n\t// Output the String\r\n\tprintf(\"\\nEntered Sentence is: %s\", str);\r\n\r\n\treturn 0;\r\n}\r\n";
        }

        private void basicCBoilerplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "#include <iostream>\r\n\r\n\r\nint main() {\r\n    // Your code goes here\r\n    return 0;\r\n}\r\n";
        }

        private void basicInputOutputExampleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textArea.Text = "#include <iostream>\r\nusing namespace std;\r\n\r\nint main() {\r\n    int num;\r\n    cout << \"Enter an integer: \";\r\n    cin >> num;   // Taking input\r\n    cout << \"The number is: \" << num;\r\n    return 0;\r\n}\r\n";
        }

        private void basicInputOutputExampleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textArea.Text = "using System;\r\n \r\nnamespace Sample\r\n{\r\n\tclass Test\r\n\t{\r\n\t\tpublic static void Main(string[] args)\r\n\t\t{\r\n\t\t\tstring testString;\r\n\t\t\tConsole.Write(\"Enter a string - \");\r\n\t\t\ttestString = Console.ReadLine();\r\n\t\t\tConsole.WriteLine(\"You entered '{0}'\", testString);\r\n\t\t}\r\n\t}\r\n}";
        }

        private void basicInputOutputExampleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textArea.Text = "# Taking input from the user\r\nname = input(\"Enter your name: \")\r\n# Output\r\nprint(\"Hello, \" + name)\r\nprint(type(name))\r\n";
        }

        private void gUIExampleTkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "import tkinter\r\nm = tkinter.Tk()\r\n'''\r\nwidgets are added here\r\n'''\r\nm.mainloop()\r\n";
        }

        private void appExampleKivyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "from kivy.app import App\r\nfrom kivy.uix.label import Label\r\n\r\nclass MainApp(App):\r\n    def build(self):\r\n        label = Label(text='Hello from Kivy',\r\n                      size_hint=(.5, .5),\r\n                      pos_hint={'center_x': .5, 'center_y': .5})\r\n\r\n        return label\r\n\r\nif __name__ == '__main__':\r\n    app = MainApp()\r\n    app.run()";
        }

        private void basicJavaBoilerplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Text = "public class HelloWorld {\r\n\r\n    public static void main(String[] args) {\r\n        System.out.println(\"Hello, World!\");\r\n    }\r\n}\r\n";
        }

        private void basicInputOutputExampleToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            textArea.Text = "import java.util.Scanner;\r\n\r\nclass Input {\r\n    public static void main(String[] args) {\r\n    \t\r\n        Scanner input = new Scanner(System.in);\r\n    \t\r\n        System.out.print(\"Enter an integer: \");\r\n        int number = input.nextInt();\r\n        System.out.println(\"You entered \" + number);\r\n\r\n        // closing the scanner object\r\n        input.close();\r\n    }\r\n}\r\n";
        }

        private void fileToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            fileToolStripMenuItem.BackColor = Color.Black;
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
