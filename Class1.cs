using (var reader = new StreamReader("C:\\Users\\Verisar\\AppData\\Local\\Hero_Siege\\save_folder\\herosiege2.pas"))
            {
                var regexname = new Regex(@"name=", RegexOptions.Compiled);
                var regexclass = new Regex(@"class=", RegexOptions.Compiled);
                var regexlevel = new Regex(@"level=", RegexOptions.Compiled);
                var regexstrength = new Regex(@"strength=", RegexOptions.Compiled);
                var regexmana = new Regex(@"swiftness=", RegexOptions.Compiled);
                var regexarmor = new Regex(@"armor=", RegexOptions.Compiled);
                var regexstamina = new Regex(@"stamina=", RegexOptions.Compiled);
                while (reader.Peek() != -1)
                {
                    var line = reader.ReadLine();
                    if (regexname.IsMatch(line)) { nametextbox1.Text = line; }
                    nametextbox2.Text = nametextbox1.Text;
                    if (regexclass.IsMatch(line)) { classtextbox1.Text = line; }
                    classtextbox2.Text = classtextbox1.Text;
                    if (regexlevel.IsMatch(line)) { leveltextbox1.Text = line; }
                    leveltextbox2.Text = leveltextbox1.Text;
                    if (regexstrength.IsMatch(line)) {  strengthtextbox1.Text = line; }
                    strengthtextbox2.Text = strengthtextbox1.Text;
                    if (regexmana.IsMatch(line)) { manatextbox1.Text = line; }
                    manatextbox2.Text = manatextbox1.Text;
                    if (regexarmor.IsMatch(line)) { armortextbox1.Text = line; }
                    armortextbox2.Text = armortextbox1.Text;
                    if (regexstamina.IsMatch(line)) { staminatextbox1.Text = line; }
                    staminatextbox2.Text = staminatextbox1.Text;
                }

            }


            string strengthtext = File.ReadAllText("C:\\Users\\Verisar\\AppData\\Local\\Hero_Siege\\save_folder\\herosiege2.pas");
            strengthtext = strengthtext.Replace(strengthtextbox1.Text, strengthtextbox2.Text);
            File.WriteAllText("C:\\Users\\Verisar\\AppData\\Local\\Hero_Siege\\save_folder\\herosiege2.pas", strengthtext);