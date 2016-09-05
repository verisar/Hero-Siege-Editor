using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Hero_Siege_Character_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.MessageBox.Show("Make sure to always load your data before saving.");
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Hero_Siege", "save_folder", "herosiege17.pas");
            using (var reader = new StreamReader(path))
            {
                var regexname = new Regex(@"name=", RegexOptions.Compiled);
                var regexclass = new Regex(@"class=", RegexOptions.Compiled);
                //var regexlevel = new Regex(@"level=", RegexOptions.Compiled);
                var regexstrength = new Regex(@"strength=", RegexOptions.Compiled);
                var regexmana = new Regex(@"swiftness=", RegexOptions.Compiled);
                var regexarmor = new Regex(@"armor=", RegexOptions.Compiled);
                var regexstamina = new Regex(@"stamina=", RegexOptions.Compiled);
                var regexwh = new Regex(@"wormhole_level=", RegexOptions.Compiled);
                var regexskill = new Regex(@"skill=", RegexOptions.Compiled);
                var regextalent = new Regex(@"talent=", RegexOptions.Compiled);
                var regextalent1 = new Regex(@"talent_1=", RegexOptions.Compiled);
                var regextalent2 = new Regex(@"talent_2=", RegexOptions.Compiled);
                var regextalent3 = new Regex(@"talent_3=", RegexOptions.Compiled);
                var regextalent4 = new Regex(@"talent_4=", RegexOptions.Compiled);
                var regextalent5 = new Regex(@"talent_5=", RegexOptions.Compiled);
                var regextalent6 = new Regex(@"talent_6=", RegexOptions.Compiled);
                var regextalent7 = new Regex(@"talent_7=", RegexOptions.Compiled);
                var regextalent8 = new Regex(@"talent_8=", RegexOptions.Compiled);
                var regextalent9 = new Regex(@"talent_9=", RegexOptions.Compiled);
                //helm
                var regexinventory00 = new Regex(@"inventory0,0=", RegexOptions.Compiled);
                var regexinventory01 = new Regex(@"inventory0,1=", RegexOptions.Compiled);
                var regexinventory02 = new Regex(@"inventory0,2=", RegexOptions.Compiled);
                var regexinventory03 = new Regex(@"inventory0,3=", RegexOptions.Compiled);
                var regexinventory04 = new Regex(@"inventory0,4=", RegexOptions.Compiled);
                var regexinventory05 = new Regex(@"inventory0,5=", RegexOptions.Compiled);
                var regexinventory06 = new Regex(@"inventory0,6=", RegexOptions.Compiled);
                var regexinventory07 = new Regex(@"inventory0,7=", RegexOptions.Compiled);
                var regexinventory08 = new Regex(@"inventory0,8=", RegexOptions.Compiled);
                var regexinventory09 = new Regex(@"inventory0,9=", RegexOptions.Compiled);
                var regexinventory010 = new Regex(@"inventory0,10=", RegexOptions.Compiled);
                var regexinventory011 = new Regex(@"inventory0,11=", RegexOptions.Compiled);
                var regexinventory012 = new Regex(@"inventory0,12=", RegexOptions.Compiled);
                var regexinventory013 = new Regex(@"inventory0,13=", RegexOptions.Compiled);
                var regexinventory014 = new Regex(@"inventory0,14=", RegexOptions.Compiled);
                var regexinventory015 = new Regex(@"inventory0,15=", RegexOptions.Compiled);
                var regexinventory016 = new Regex(@"inventory0,16=", RegexOptions.Compiled);
                var regexinventory017 = new Regex(@"inventory0,17=", RegexOptions.Compiled);
                var regexinventory018 = new Regex(@"inventory0,18=", RegexOptions.Compiled);
                var regexinventory019 = new Regex(@"inventory0,19=", RegexOptions.Compiled);
                var regexinventory020 = new Regex(@"inventory0,20=", RegexOptions.Compiled);
                var regexinventory021 = new Regex(@"inventory0,21=", RegexOptions.Compiled);
                var regexinventory022 = new Regex(@"inventory0,22=", RegexOptions.Compiled);
                var regexinventory023 = new Regex(@"inventory0,23=", RegexOptions.Compiled);
                var regexinventory024 = new Regex(@"inventory0,24=", RegexOptions.Compiled);
                var regexinventory025 = new Regex(@"inventory0,25=", RegexOptions.Compiled);
                var regexinventory026 = new Regex(@"inventory0,26=", RegexOptions.Compiled);
                var regexinventory027 = new Regex(@"inventory0,27=", RegexOptions.Compiled);
                var regexinventory028 = new Regex(@"inventory0,28=", RegexOptions.Compiled);
                var regexinventory029 = new Regex(@"inventory0,29=", RegexOptions.Compiled);
                //chest
                var regexinventory10 = new Regex(@"inventory1,0=", RegexOptions.Compiled);
                var regexinventory11 = new Regex(@"inventory1,1=", RegexOptions.Compiled);
                var regexinventory12 = new Regex(@"inventory1,2=", RegexOptions.Compiled);
                var regexinventory13 = new Regex(@"inventory1,3=", RegexOptions.Compiled);
                var regexinventory14 = new Regex(@"inventory1,4=", RegexOptions.Compiled);
                var regexinventory15 = new Regex(@"inventory1,5=", RegexOptions.Compiled);
                var regexinventory16 = new Regex(@"inventory1,6=", RegexOptions.Compiled);
                var regexinventory17 = new Regex(@"inventory1,7=", RegexOptions.Compiled);
                var regexinventory18 = new Regex(@"inventory1,8=", RegexOptions.Compiled);
                var regexinventory19 = new Regex(@"inventory1,9=", RegexOptions.Compiled);
                var regexinventory110 = new Regex(@"inventory1,10=", RegexOptions.Compiled);
                var regexinventory111 = new Regex(@"inventory1,11=", RegexOptions.Compiled);
                var regexinventory112 = new Regex(@"inventory1,12=", RegexOptions.Compiled);
                var regexinventory113 = new Regex(@"inventory1,13=", RegexOptions.Compiled);
                var regexinventory114 = new Regex(@"inventory1,14=", RegexOptions.Compiled);
                var regexinventory115 = new Regex(@"inventory1,15=", RegexOptions.Compiled);
                var regexinventory116 = new Regex(@"inventory1,16=", RegexOptions.Compiled);
                var regexinventory117 = new Regex(@"inventory1,17=", RegexOptions.Compiled);
                var regexinventory118 = new Regex(@"inventory1,18=", RegexOptions.Compiled);
                var regexinventory119 = new Regex(@"inventory1,19=", RegexOptions.Compiled);
                var regexinventory120 = new Regex(@"inventory1,20=", RegexOptions.Compiled);
                var regexinventory121 = new Regex(@"inventory1,21=", RegexOptions.Compiled);
                var regexinventory122 = new Regex(@"inventory1,22=", RegexOptions.Compiled);
                var regexinventory123 = new Regex(@"inventory1,23=", RegexOptions.Compiled);
                var regexinventory124 = new Regex(@"inventory1,24=", RegexOptions.Compiled);
                var regexinventory125 = new Regex(@"inventory1,25=", RegexOptions.Compiled);
                var regexinventory126 = new Regex(@"inventory1,26=", RegexOptions.Compiled);
                var regexinventory127 = new Regex(@"inventory1,27=", RegexOptions.Compiled);
                var regexinventory128 = new Regex(@"inventory1,28=", RegexOptions.Compiled);
                var regexinventory129 = new Regex(@"inventory1,29=", RegexOptions.Compiled);
                // Boots
                var regexinventory20 = new Regex(@"inventory2,0=", RegexOptions.Compiled);
                var regexinventory21 = new Regex(@"inventory2,1=", RegexOptions.Compiled);
                var regexinventory22 = new Regex(@"inventory2,2=", RegexOptions.Compiled);
                var regexinventory23 = new Regex(@"inventory2,3=", RegexOptions.Compiled);
                var regexinventory24 = new Regex(@"inventory2,4=", RegexOptions.Compiled);
                var regexinventory25 = new Regex(@"inventory2,5=", RegexOptions.Compiled);
                var regexinventory26 = new Regex(@"inventory2,6=", RegexOptions.Compiled);
                var regexinventory27 = new Regex(@"inventory2,7=", RegexOptions.Compiled);
                var regexinventory28 = new Regex(@"inventory2,8=", RegexOptions.Compiled);
                var regexinventory29 = new Regex(@"inventory2,9=", RegexOptions.Compiled);
                var regexinventory210 = new Regex(@"inventory2,10=", RegexOptions.Compiled);
                var regexinventory211 = new Regex(@"inventory2,11=", RegexOptions.Compiled);
                var regexinventory212 = new Regex(@"inventory2,12=", RegexOptions.Compiled);
                var regexinventory213 = new Regex(@"inventory2,13=", RegexOptions.Compiled);
                var regexinventory214 = new Regex(@"inventory2,14=", RegexOptions.Compiled);
                var regexinventory215 = new Regex(@"inventory2,15=", RegexOptions.Compiled);
                var regexinventory216 = new Regex(@"inventory2,16=", RegexOptions.Compiled);
                var regexinventory217 = new Regex(@"inventory2,17=", RegexOptions.Compiled);
                var regexinventory218 = new Regex(@"inventory2,18=", RegexOptions.Compiled);
                var regexinventory219 = new Regex(@"inventory2,19=", RegexOptions.Compiled);
                var regexinventory220 = new Regex(@"inventory2,20=", RegexOptions.Compiled);
                var regexinventory221 = new Regex(@"inventory2,21=", RegexOptions.Compiled);
                var regexinventory222 = new Regex(@"inventory2,22=", RegexOptions.Compiled);
                var regexinventory223 = new Regex(@"inventory2,23=", RegexOptions.Compiled);
                var regexinventory224 = new Regex(@"inventory2,24=", RegexOptions.Compiled);
                var regexinventory225 = new Regex(@"inventory2,25=", RegexOptions.Compiled);
                var regexinventory226 = new Regex(@"inventory2,26=", RegexOptions.Compiled);
                var regexinventory227 = new Regex(@"inventory2,27=", RegexOptions.Compiled);
                var regexinventory228 = new Regex(@"inventory2,28=", RegexOptions.Compiled);
                var regexinventory229 = new Regex(@"inventory2,29=", RegexOptions.Compiled);
                //Weapon
                var regexinventory30 = new Regex(@"inventory3,0=", RegexOptions.Compiled);
                var regexinventory31 = new Regex(@"inventory3,1=", RegexOptions.Compiled);
                var regexinventory32 = new Regex(@"inventory3,2=", RegexOptions.Compiled);
                var regexinventory33 = new Regex(@"inventory3,3=", RegexOptions.Compiled);
                var regexinventory34 = new Regex(@"inventory3,4=", RegexOptions.Compiled);
                var regexinventory35 = new Regex(@"inventory3,5=", RegexOptions.Compiled);
                var regexinventory36 = new Regex(@"inventory3,6=", RegexOptions.Compiled);
                var regexinventory37 = new Regex(@"inventory3,7=", RegexOptions.Compiled);
                var regexinventory38 = new Regex(@"inventory3,8=", RegexOptions.Compiled);
                var regexinventory39 = new Regex(@"inventory3,9=", RegexOptions.Compiled);
                var regexinventory310 = new Regex(@"inventory3,10=", RegexOptions.Compiled);
                var regexinventory311 = new Regex(@"inventory3,11=", RegexOptions.Compiled);
                var regexinventory312 = new Regex(@"inventory3,12=", RegexOptions.Compiled);
                var regexinventory313 = new Regex(@"inventory3,13=", RegexOptions.Compiled);
                var regexinventory314 = new Regex(@"inventory3,14=", RegexOptions.Compiled);
                var regexinventory315 = new Regex(@"inventory3,15=", RegexOptions.Compiled);
                var regexinventory316 = new Regex(@"inventory3,16=", RegexOptions.Compiled);
                var regexinventory317 = new Regex(@"inventory3,17=", RegexOptions.Compiled);
                var regexinventory318 = new Regex(@"inventory3,18=", RegexOptions.Compiled);
                var regexinventory319 = new Regex(@"inventory3,19=", RegexOptions.Compiled);
                var regexinventory320 = new Regex(@"inventory3,20=", RegexOptions.Compiled);
                var regexinventory321 = new Regex(@"inventory3,21=", RegexOptions.Compiled);
                var regexinventory322 = new Regex(@"inventory3,22=", RegexOptions.Compiled);
                var regexinventory323 = new Regex(@"inventory3,23=", RegexOptions.Compiled);
                var regexinventory324 = new Regex(@"inventory3,24=", RegexOptions.Compiled);
                var regexinventory325 = new Regex(@"inventory3,25=", RegexOptions.Compiled);
                var regexinventory326 = new Regex(@"inventory3,26=", RegexOptions.Compiled);
                var regexinventory327 = new Regex(@"inventory3,27=", RegexOptions.Compiled);
                var regexinventory328 = new Regex(@"inventory3,28=", RegexOptions.Compiled);
                var regexinventory329 = new Regex(@"inventory3,29=", RegexOptions.Compiled);
                //Gloves
                var regexinventory40 = new Regex(@"inventory4,0=", RegexOptions.Compiled);
                var regexinventory41 = new Regex(@"inventory4,1=", RegexOptions.Compiled);
                var regexinventory42 = new Regex(@"inventory4,2=", RegexOptions.Compiled);
                var regexinventory43 = new Regex(@"inventory4,3=", RegexOptions.Compiled);
                var regexinventory44 = new Regex(@"inventory4,4=", RegexOptions.Compiled);
                var regexinventory45 = new Regex(@"inventory4,5=", RegexOptions.Compiled);
                var regexinventory46 = new Regex(@"inventory4,6=", RegexOptions.Compiled);
                var regexinventory47 = new Regex(@"inventory4,7=", RegexOptions.Compiled);
                var regexinventory48 = new Regex(@"inventory4,8=", RegexOptions.Compiled);
                var regexinventory49 = new Regex(@"inventory4,9=", RegexOptions.Compiled);
                var regexinventory410 = new Regex(@"inventory4,10=", RegexOptions.Compiled);
                var regexinventory411 = new Regex(@"inventory4,11=", RegexOptions.Compiled);
                var regexinventory412 = new Regex(@"inventory4,12=", RegexOptions.Compiled);
                var regexinventory413 = new Regex(@"inventory4,13=", RegexOptions.Compiled);
                var regexinventory414 = new Regex(@"inventory4,14=", RegexOptions.Compiled);
                var regexinventory415 = new Regex(@"inventory4,15=", RegexOptions.Compiled);
                var regexinventory416 = new Regex(@"inventory4,16=", RegexOptions.Compiled);
                var regexinventory417 = new Regex(@"inventory4,17=", RegexOptions.Compiled);
                var regexinventory418 = new Regex(@"inventory4,18=", RegexOptions.Compiled);
                var regexinventory419 = new Regex(@"inventory4,19=", RegexOptions.Compiled);
                var regexinventory420 = new Regex(@"inventory4,20=", RegexOptions.Compiled);
                var regexinventory421 = new Regex(@"inventory4,21=", RegexOptions.Compiled);
                var regexinventory422 = new Regex(@"inventory4,22=", RegexOptions.Compiled);
                var regexinventory423 = new Regex(@"inventory4,23=", RegexOptions.Compiled);
                var regexinventory424 = new Regex(@"inventory4,24=", RegexOptions.Compiled);
                var regexinventory425 = new Regex(@"inventory4,25=", RegexOptions.Compiled);
                var regexinventory426 = new Regex(@"inventory4,26=", RegexOptions.Compiled);
                var regexinventory427 = new Regex(@"inventory4,27=", RegexOptions.Compiled);
                var regexinventory428 = new Regex(@"inventory4,28=", RegexOptions.Compiled);
                var regexinventory429 = new Regex(@"inventory4,29=", RegexOptions.Compiled);
                //Amulet
                var regexinventory50 = new Regex(@"inventory5,0=", RegexOptions.Compiled);
                var regexinventory51 = new Regex(@"inventory5,1=", RegexOptions.Compiled);
                var regexinventory52 = new Regex(@"inventory5,2=", RegexOptions.Compiled);
                var regexinventory53 = new Regex(@"inventory5,3=", RegexOptions.Compiled);
                var regexinventory54 = new Regex(@"inventory5,4=", RegexOptions.Compiled);
                var regexinventory55 = new Regex(@"inventory5,5=", RegexOptions.Compiled);
                var regexinventory56 = new Regex(@"inventory5,6=", RegexOptions.Compiled);
                var regexinventory57 = new Regex(@"inventory5,7=", RegexOptions.Compiled);
                var regexinventory58 = new Regex(@"inventory5,8=", RegexOptions.Compiled);
                var regexinventory59 = new Regex(@"inventory5,9=", RegexOptions.Compiled);
                var regexinventory510 = new Regex(@"inventory5,10=", RegexOptions.Compiled);
                var regexinventory511 = new Regex(@"inventory5,11=", RegexOptions.Compiled);
                var regexinventory512 = new Regex(@"inventory5,12=", RegexOptions.Compiled);
                var regexinventory513 = new Regex(@"inventory5,13=", RegexOptions.Compiled);
                var regexinventory514 = new Regex(@"inventory5,14=", RegexOptions.Compiled);
                var regexinventory515 = new Regex(@"inventory5,15=", RegexOptions.Compiled);
                var regexinventory516 = new Regex(@"inventory5,16=", RegexOptions.Compiled);
                var regexinventory517 = new Regex(@"inventory5,17=", RegexOptions.Compiled);
                var regexinventory518 = new Regex(@"inventory5,18=", RegexOptions.Compiled);
                var regexinventory519 = new Regex(@"inventory5,19=", RegexOptions.Compiled);
                var regexinventory520 = new Regex(@"inventory5,20=", RegexOptions.Compiled);
                var regexinventory521 = new Regex(@"inventory5,21=", RegexOptions.Compiled);
                var regexinventory522 = new Regex(@"inventory5,22=", RegexOptions.Compiled);
                var regexinventory523 = new Regex(@"inventory5,23=", RegexOptions.Compiled);
                var regexinventory524 = new Regex(@"inventory5,24=", RegexOptions.Compiled);
                var regexinventory525 = new Regex(@"inventory5,25=", RegexOptions.Compiled);
                var regexinventory526 = new Regex(@"inventory5,26=", RegexOptions.Compiled);
                var regexinventory527 = new Regex(@"inventory5,27=", RegexOptions.Compiled);
                var regexinventory528 = new Regex(@"inventory5,28=", RegexOptions.Compiled);
                var regexinventory529 = new Regex(@"inventory5,29=", RegexOptions.Compiled);
                //Charm
                var regexinventory60 = new Regex(@"inventory6,0=", RegexOptions.Compiled);
                var regexinventory61 = new Regex(@"inventory6,1=", RegexOptions.Compiled);
                var regexinventory62 = new Regex(@"inventory6,2=", RegexOptions.Compiled);
                var regexinventory63 = new Regex(@"inventory6,3=", RegexOptions.Compiled);
                var regexinventory64 = new Regex(@"inventory6,4=", RegexOptions.Compiled);
                var regexinventory65 = new Regex(@"inventory6,5=", RegexOptions.Compiled);
                var regexinventory66 = new Regex(@"inventory6,6=", RegexOptions.Compiled);
                var regexinventory67 = new Regex(@"inventory6,7=", RegexOptions.Compiled);
                var regexinventory68 = new Regex(@"inventory6,8=", RegexOptions.Compiled);
                var regexinventory69 = new Regex(@"inventory6,9=", RegexOptions.Compiled);
                var regexinventory610 = new Regex(@"inventory6,10=", RegexOptions.Compiled);
                var regexinventory611 = new Regex(@"inventory6,11=", RegexOptions.Compiled);
                var regexinventory612 = new Regex(@"inventory6,12=", RegexOptions.Compiled);
                var regexinventory613 = new Regex(@"inventory6,13=", RegexOptions.Compiled);
                var regexinventory614 = new Regex(@"inventory6,14=", RegexOptions.Compiled);
                var regexinventory615 = new Regex(@"inventory6,15=", RegexOptions.Compiled);
                var regexinventory616 = new Regex(@"inventory6,16=", RegexOptions.Compiled);
                var regexinventory617 = new Regex(@"inventory6,17=", RegexOptions.Compiled);
                var regexinventory618 = new Regex(@"inventory6,18=", RegexOptions.Compiled);
                var regexinventory619 = new Regex(@"inventory6,19=", RegexOptions.Compiled);
                var regexinventory620 = new Regex(@"inventory6,20=", RegexOptions.Compiled);
                var regexinventory621 = new Regex(@"inventory6,21=", RegexOptions.Compiled);
                var regexinventory622 = new Regex(@"inventory6,22=", RegexOptions.Compiled);
                var regexinventory623 = new Regex(@"inventory6,23=", RegexOptions.Compiled);
                var regexinventory624 = new Regex(@"inventory6,24=", RegexOptions.Compiled);
                var regexinventory625 = new Regex(@"inventory6,25=", RegexOptions.Compiled);
                var regexinventory626 = new Regex(@"inventory6,26=", RegexOptions.Compiled);
                var regexinventory627 = new Regex(@"inventory6,27=", RegexOptions.Compiled);
                var regexinventory628 = new Regex(@"inventory6,28=", RegexOptions.Compiled);
                var regexinventory629 = new Regex(@"inventory6,29=", RegexOptions.Compiled);

                while (reader.Peek() != -1)
                {
                    var line = reader.ReadLine();
                    if (regexname.IsMatch(line)) { nametextbox1.Text = line; }
                    nametextbox2.Text = nametextbox1.Text;
                    if (regexclass.IsMatch(line)) { classtextbox1.Text = line; }
                    classtextbox2.Text = classtextbox1.Text;
                    //if (regexlevel.IsMatch(line)) { leveltextbox1.Text = line; }
                    //leveltextbox2.Text = leveltextbox1.Text;
                    if (regexstrength.IsMatch(line)) { strengthtextbox1.Text = line; }
                    strengthtextbox2.Text = strengthtextbox1.Text;
                    if (regexmana.IsMatch(line)) { manatextbox1.Text = line; }
                    manatextbox2.Text = manatextbox1.Text;
                    if (regexarmor.IsMatch(line)) { armortextbox1.Text = line; }
                    armortextbox2.Text = armortextbox1.Text;
                    if (regexstamina.IsMatch(line)) { staminatextbox1.Text = line; }
                    staminatextbox2.Text = staminatextbox1.Text;
                    if (regexwh.IsMatch(line)) { whtb1.Text = line; }
                    whtb2.Text = whtb1.Text;
                    if (regexskill.IsMatch(line)) { skilltb1.Text = line; }
                    skilltb2.Text = skilltb1.Text;
                    if (regextalent.IsMatch(line)) { talenttb1.Text = line; }
                    talenttb2.Text = talenttb1.Text;
                    if (regextalent1.IsMatch(line)) { talent1tb1.Text = line; }
                    talent1tb2.Text = talent1tb1.Text;
                    if (regextalent2.IsMatch(line)) { talent2tb1.Text = line; }
                    talent2tb2.Text = talent2tb1.Text;
                    if (regextalent3.IsMatch(line)) { talent3tb1.Text = line; }
                    talent3tb2.Text = talent3tb1.Text;
                    if (regextalent4.IsMatch(line)) { talent4tb1.Text = line; }
                    talent4tb2.Text = talent4tb1.Text;
                    if (regextalent5.IsMatch(line)) { talent5tb1.Text = line; }
                    talent5tb2.Text = talent5tb1.Text;
                    if (regextalent6.IsMatch(line)) { talent6tb1.Text = line; }
                    talent6tb2.Text = talent6tb1.Text;
                    if (regextalent7.IsMatch(line)) { talent7tb1.Text = line; }
                    talent7tb2.Text = talent7tb1.Text;
                    if (regextalent8.IsMatch(line)) { talent8tb1.Text = line; }
                    talent8tb2.Text = talent8tb1.Text;
                    if (regextalent9.IsMatch(line)) { talent9tb1.Text = line; }
                    talent9tb2.Text = talent9tb1.Text;
                    //gear
                    if (regexinventory00.IsMatch(line)) { inventory00tb1.Text = line; }
                    inventory00tb2.Text = inventory00tb1.Text;
                    if (regexinventory01.IsMatch(line)) { inventory01tb1.Text = line; }
                    inventory01tb2.Text = inventory01tb1.Text;
                    if (regexinventory02.IsMatch(line)) { inventory02tb1.Text = line; }
                    inventory02tb2.Text = inventory02tb1.Text;
                    if (regexinventory03.IsMatch(line)) { inventory03tb1.Text = line; }
                    inventory03tb2.Text = inventory03tb1.Text;
                    if (regexinventory04.IsMatch(line)) { inventory04tb1.Text = line; }
                    inventory04tb2.Text = inventory04tb1.Text;
                    if (regexinventory05.IsMatch(line)) { inventory05tb1.Text = line; }
                    inventory05tb2.Text = inventory05tb1.Text;
                    if (regexinventory06.IsMatch(line)) { inventory06tb1.Text = line; }
                    inventory06tb2.Text = inventory06tb1.Text;
                    if (regexinventory07.IsMatch(line)) { inventory07tb1.Text = line; }
                    inventory07tb2.Text = inventory07tb1.Text;
                    if (regexinventory08.IsMatch(line)) { inventory08tb1.Text = line; }
                    inventory08tb2.Text = inventory08tb1.Text;
                    if (regexinventory09.IsMatch(line)) { inventory09tb1.Text = line; }
                    inventory09tb2.Text = inventory09tb1.Text;
                    if (regexinventory010.IsMatch(line)) { inventory010tb1.Text = line; }
                    inventory010tb2.Text = inventory010tb1.Text;
                    if (regexinventory011.IsMatch(line)) { inventory011tb1.Text = line; }
                    inventory011tb2.Text = inventory011tb1.Text;
                    if (regexinventory012.IsMatch(line)) { inventory012tb1.Text = line; }
                    inventory012tb2.Text = inventory012tb1.Text;
                    if (regexinventory013.IsMatch(line)) { inventory013tb1.Text = line; }
                    inventory013tb2.Text = inventory013tb1.Text;
                    if (regexinventory014.IsMatch(line)) { inventory014tb1.Text = line; }
                    inventory014tb2.Text = inventory014tb1.Text;
                    if (regexinventory015.IsMatch(line)) { inventory015tb1.Text = line; }
                    inventory015tb2.Text = inventory015tb1.Text;
                    if (regexinventory016.IsMatch(line)) { inventory016tb1.Text = line; }
                    inventory016tb2.Text = inventory016tb1.Text;
                    if (regexinventory017.IsMatch(line)) { inventory017tb1.Text = line; }
                    inventory017tb2.Text = inventory017tb1.Text;
                    if (regexinventory018.IsMatch(line)) { inventory018tb1.Text = line; }
                    inventory018tb2.Text = inventory018tb1.Text;
                    if (regexinventory019.IsMatch(line)) { inventory019tb1.Text = line; }
                    inventory019tb2.Text = inventory019tb1.Text;
                    if (regexinventory020.IsMatch(line)) { inventory020tb1.Text = line; }
                    inventory020tb2.Text = inventory020tb1.Text;
                    if (regexinventory021.IsMatch(line)) { inventory021tb1.Text = line; }
                    inventory021tb2.Text = inventory021tb1.Text;
                    if (regexinventory022.IsMatch(line)) { inventory022tb1.Text = line; }
                    inventory022tb2.Text = inventory022tb1.Text;
                    if (regexinventory023.IsMatch(line)) { inventory023tb1.Text = line; }
                    inventory023tb2.Text = inventory023tb1.Text;
                    if (regexinventory024.IsMatch(line)) { inventory024tb1.Text = line; }
                    inventory024tb2.Text = inventory024tb1.Text;
                    if (regexinventory025.IsMatch(line)) { inventory025tb1.Text = line; }
                    inventory025tb2.Text = inventory025tb1.Text;
                    if (regexinventory026.IsMatch(line)) { inventory026tb1.Text = line; }
                    inventory026tb2.Text = inventory026tb1.Text;
                    if (regexinventory027.IsMatch(line)) { inventory027tb1.Text = line; }
                    inventory027tb2.Text = inventory027tb1.Text;
                    if (regexinventory028.IsMatch(line)) { inventory028tb1.Text = line; }
                    inventory028tb2.Text = inventory028tb1.Text;
                    if (regexinventory029.IsMatch(line)) { inventory029tb1.Text = line; }
                    inventory029tb2.Text = inventory029tb1.Text;
                    if (regexinventory10.IsMatch(line)) { inventory10tb1.Text = line; }
                    inventory10tb2.Text = inventory10tb1.Text;
                    if (regexinventory11.IsMatch(line)) { inventory11tb1.Text = line; }
                    inventory11tb2.Text = inventory11tb1.Text;
                    if (regexinventory12.IsMatch(line)) { inventory12tb1.Text = line; }
                    inventory12tb2.Text = inventory12tb1.Text;
                    if (regexinventory13.IsMatch(line)) { inventory13tb1.Text = line; }
                    inventory13tb2.Text = inventory13tb1.Text;
                    if (regexinventory14.IsMatch(line)) { inventory14tb1.Text = line; }
                    inventory14tb2.Text = inventory14tb1.Text;
                    if (regexinventory15.IsMatch(line)) { inventory15tb1.Text = line; }
                    inventory15tb2.Text = inventory15tb1.Text;
                    if (regexinventory16.IsMatch(line)) { inventory16tb1.Text = line; }
                    inventory16tb2.Text = inventory16tb1.Text;
                    if (regexinventory17.IsMatch(line)) { inventory17tb1.Text = line; }
                    inventory17tb2.Text = inventory17tb1.Text;
                    if (regexinventory18.IsMatch(line)) { inventory18tb1.Text = line; }
                    inventory18tb2.Text = inventory18tb1.Text;
                    if (regexinventory19.IsMatch(line)) { inventory19tb1.Text = line; }
                    inventory19tb2.Text = inventory19tb1.Text;
                    if (regexinventory110.IsMatch(line)) { inventory110tb1.Text = line; }
                    inventory110tb2.Text = inventory110tb1.Text;
                    if (regexinventory111.IsMatch(line)) { inventory111tb1.Text = line; }
                    inventory111tb2.Text = inventory111tb1.Text;
                    if (regexinventory112.IsMatch(line)) { inventory112tb1.Text = line; }
                    inventory112tb2.Text = inventory112tb1.Text;
                    if (regexinventory113.IsMatch(line)) { inventory113tb1.Text = line; }
                    inventory113tb2.Text = inventory113tb1.Text;
                    if (regexinventory114.IsMatch(line)) { inventory114tb1.Text = line; }
                    inventory114tb2.Text = inventory114tb1.Text;
                    if (regexinventory115.IsMatch(line)) { inventory115tb1.Text = line; }
                    inventory115tb2.Text = inventory115tb1.Text;
                    if (regexinventory116.IsMatch(line)) { inventory116tb1.Text = line; }
                    inventory116tb2.Text = inventory116tb1.Text;
                    if (regexinventory117.IsMatch(line)) { inventory117tb1.Text = line; }
                    inventory117tb2.Text = inventory117tb1.Text;
                    if (regexinventory118.IsMatch(line)) { inventory118tb1.Text = line; }
                    inventory118tb2.Text = inventory118tb1.Text;
                    if (regexinventory119.IsMatch(line)) { inventory119tb1.Text = line; }
                    inventory119tb2.Text = inventory119tb1.Text;
                    if (regexinventory120.IsMatch(line)) { inventory120tb1.Text = line; }
                    inventory120tb2.Text = inventory120tb1.Text;
                    if (regexinventory121.IsMatch(line)) { inventory121tb1.Text = line; }
                    inventory121tb2.Text = inventory121tb1.Text;
                    if (regexinventory122.IsMatch(line)) { inventory122tb1.Text = line; }
                    inventory122tb2.Text = inventory122tb1.Text;
                    if (regexinventory123.IsMatch(line)) { inventory123tb1.Text = line; }
                    inventory123tb2.Text = inventory123tb1.Text;
                    if (regexinventory124.IsMatch(line)) { inventory124tb1.Text = line; }
                    inventory124tb2.Text = inventory124tb1.Text;
                    if (regexinventory125.IsMatch(line)) { inventory125tb1.Text = line; }
                    inventory125tb2.Text = inventory125tb1.Text;
                    if (regexinventory126.IsMatch(line)) { inventory126tb1.Text = line; }
                    inventory126tb2.Text = inventory126tb1.Text;
                    if (regexinventory127.IsMatch(line)) { inventory127tb1.Text = line; }
                    inventory127tb2.Text = inventory127tb1.Text;
                    if (regexinventory128.IsMatch(line)) { inventory128tb1.Text = line; }
                    inventory128tb2.Text = inventory128tb1.Text;
                    if (regexinventory129.IsMatch(line)) { inventory129tb1.Text = line; }
                    inventory129tb2.Text = inventory129tb1.Text;
                    if (regexinventory20.IsMatch(line)) { inventory20tb1.Text = line; }
                    inventory20tb2.Text = inventory20tb1.Text;
                    if (regexinventory21.IsMatch(line)) { inventory21tb1.Text = line; }
                    inventory21tb2.Text = inventory21tb1.Text;
                    if (regexinventory22.IsMatch(line)) { inventory22tb1.Text = line; }
                    inventory22tb2.Text = inventory22tb1.Text;
                    if (regexinventory23.IsMatch(line)) { inventory23tb1.Text = line; }
                    inventory23tb2.Text = inventory23tb1.Text;
                    if (regexinventory24.IsMatch(line)) { inventory24tb1.Text = line; }
                    inventory24tb2.Text = inventory24tb1.Text;
                    if (regexinventory25.IsMatch(line)) { inventory25tb1.Text = line; }
                    inventory25tb2.Text = inventory25tb1.Text;
                    if (regexinventory26.IsMatch(line)) { inventory26tb1.Text = line; }
                    inventory26tb2.Text = inventory26tb1.Text;
                    if (regexinventory27.IsMatch(line)) { inventory27tb1.Text = line; }
                    inventory27tb2.Text = inventory27tb1.Text;
                    if (regexinventory28.IsMatch(line)) { inventory28tb1.Text = line; }
                    inventory28tb2.Text = inventory28tb1.Text;
                    if (regexinventory29.IsMatch(line)) { inventory29tb1.Text = line; }
                    inventory29tb2.Text = inventory29tb1.Text;
                    if (regexinventory210.IsMatch(line)) { inventory210tb1.Text = line; }
                    inventory210tb2.Text = inventory210tb1.Text;
                    if (regexinventory211.IsMatch(line)) { inventory211tb1.Text = line; }
                    inventory211tb2.Text = inventory211tb1.Text;
                    if (regexinventory212.IsMatch(line)) { inventory212tb1.Text = line; }
                    inventory212tb2.Text = inventory212tb1.Text;
                    if (regexinventory213.IsMatch(line)) { inventory213tb1.Text = line; }
                    inventory213tb2.Text = inventory213tb1.Text;
                    if (regexinventory214.IsMatch(line)) { inventory214tb1.Text = line; }
                    inventory214tb2.Text = inventory214tb1.Text;
                    if (regexinventory215.IsMatch(line)) { inventory215tb1.Text = line; }
                    inventory215tb2.Text = inventory215tb1.Text;
                    if (regexinventory216.IsMatch(line)) { inventory216tb1.Text = line; }
                    inventory216tb2.Text = inventory216tb1.Text;
                    if (regexinventory217.IsMatch(line)) { inventory217tb1.Text = line; }
                    inventory217tb2.Text = inventory217tb1.Text;
                    if (regexinventory218.IsMatch(line)) { inventory218tb1.Text = line; }
                    inventory218tb2.Text = inventory218tb1.Text;
                    if (regexinventory219.IsMatch(line)) { inventory219tb1.Text = line; }
                    inventory219tb2.Text = inventory219tb1.Text;
                    if (regexinventory220.IsMatch(line)) { inventory220tb1.Text = line; }
                    inventory220tb2.Text = inventory220tb1.Text;
                    if (regexinventory221.IsMatch(line)) { inventory221tb1.Text = line; }
                    inventory221tb2.Text = inventory221tb1.Text;
                    if (regexinventory222.IsMatch(line)) { inventory222tb1.Text = line; }
                    inventory222tb2.Text = inventory222tb1.Text;
                    if (regexinventory223.IsMatch(line)) { inventory223tb1.Text = line; }
                    inventory223tb2.Text = inventory223tb1.Text;
                    if (regexinventory224.IsMatch(line)) { inventory224tb1.Text = line; }
                    inventory224tb2.Text = inventory224tb1.Text;
                    if (regexinventory225.IsMatch(line)) { inventory225tb1.Text = line; }
                    inventory225tb2.Text = inventory225tb1.Text;
                    if (regexinventory226.IsMatch(line)) { inventory226tb1.Text = line; }
                    inventory226tb2.Text = inventory226tb1.Text;
                    if (regexinventory227.IsMatch(line)) { inventory227tb1.Text = line; }
                    inventory227tb2.Text = inventory227tb1.Text;
                    if (regexinventory228.IsMatch(line)) { inventory228tb1.Text = line; }
                    inventory228tb2.Text = inventory228tb1.Text;
                    if (regexinventory229.IsMatch(line)) { inventory229tb1.Text = line; }
                    inventory229tb2.Text = inventory229tb1.Text;
                    if (regexinventory30.IsMatch(line)) { inventory30tb1.Text = line; }
                    inventory30tb2.Text = inventory30tb1.Text;
                    if (regexinventory31.IsMatch(line)) { inventory31tb1.Text = line; }
                    inventory31tb2.Text = inventory31tb1.Text;
                    if (regexinventory32.IsMatch(line)) { inventory32tb1.Text = line; }
                    inventory32tb2.Text = inventory32tb1.Text;
                    if (regexinventory33.IsMatch(line)) { inventory33tb1.Text = line; }
                    inventory33tb2.Text = inventory33tb1.Text;
                    if (regexinventory34.IsMatch(line)) { inventory34tb1.Text = line; }
                    inventory34tb2.Text = inventory34tb1.Text;
                    if (regexinventory35.IsMatch(line)) { inventory35tb1.Text = line; }
                    inventory35tb2.Text = inventory35tb1.Text;
                    if (regexinventory36.IsMatch(line)) { inventory36tb1.Text = line; }
                    inventory36tb2.Text = inventory36tb1.Text;
                    if (regexinventory37.IsMatch(line)) { inventory37tb1.Text = line; }
                    inventory37tb2.Text = inventory37tb1.Text;
                    if (regexinventory38.IsMatch(line)) { inventory38tb1.Text = line; }
                    inventory38tb2.Text = inventory38tb1.Text;
                    if (regexinventory39.IsMatch(line)) { inventory39tb1.Text = line; }
                    inventory39tb2.Text = inventory39tb1.Text;
                    if (regexinventory310.IsMatch(line)) { inventory310tb1.Text = line; }
                    inventory310tb2.Text = inventory310tb1.Text;
                    if (regexinventory311.IsMatch(line)) { inventory311tb1.Text = line; }
                    inventory311tb2.Text = inventory311tb1.Text;
                    if (regexinventory312.IsMatch(line)) { inventory312tb1.Text = line; }
                    inventory312tb2.Text = inventory312tb1.Text;
                    if (regexinventory313.IsMatch(line)) { inventory313tb1.Text = line; }
                    inventory313tb2.Text = inventory313tb1.Text;
                    if (regexinventory314.IsMatch(line)) { inventory314tb1.Text = line; }
                    inventory314tb2.Text = inventory314tb1.Text;
                    if (regexinventory315.IsMatch(line)) { inventory315tb1.Text = line; }
                    inventory315tb2.Text = inventory315tb1.Text;
                    if (regexinventory316.IsMatch(line)) { inventory316tb1.Text = line; }
                    inventory316tb2.Text = inventory316tb1.Text;
                    if (regexinventory317.IsMatch(line)) { inventory317tb1.Text = line; }
                    inventory317tb2.Text = inventory317tb1.Text;
                    if (regexinventory318.IsMatch(line)) { inventory318tb1.Text = line; }
                    inventory318tb2.Text = inventory318tb1.Text;
                    if (regexinventory319.IsMatch(line)) { inventory319tb1.Text = line; }
                    inventory319tb2.Text = inventory319tb1.Text;
                    if (regexinventory320.IsMatch(line)) { inventory320tb1.Text = line; }
                    inventory320tb2.Text = inventory320tb1.Text;
                    if (regexinventory321.IsMatch(line)) { inventory321tb1.Text = line; }
                    inventory321tb2.Text = inventory321tb1.Text;
                    if (regexinventory322.IsMatch(line)) { inventory322tb1.Text = line; }
                    inventory322tb2.Text = inventory322tb1.Text;
                    if (regexinventory323.IsMatch(line)) { inventory323tb1.Text = line; }
                    inventory323tb2.Text = inventory323tb1.Text;
                    if (regexinventory324.IsMatch(line)) { inventory324tb1.Text = line; }
                    inventory324tb2.Text = inventory324tb1.Text;
                    if (regexinventory325.IsMatch(line)) { inventory325tb1.Text = line; }
                    inventory325tb2.Text = inventory325tb1.Text;
                    if (regexinventory326.IsMatch(line)) { inventory326tb1.Text = line; }
                    inventory326tb2.Text = inventory326tb1.Text;
                    if (regexinventory327.IsMatch(line)) { inventory327tb1.Text = line; }
                    inventory327tb2.Text = inventory327tb1.Text;
                    if (regexinventory328.IsMatch(line)) { inventory328tb1.Text = line; }
                    inventory328tb2.Text = inventory328tb1.Text;
                    if (regexinventory329.IsMatch(line)) { inventory329tb1.Text = line; }
                    inventory329tb2.Text = inventory329tb1.Text;
                    if (regexinventory40.IsMatch(line)) { inventory40tb1.Text = line; }
                    inventory40tb2.Text = inventory40tb1.Text;
                    if (regexinventory41.IsMatch(line)) { inventory41tb1.Text = line; }
                    inventory41tb2.Text = inventory41tb1.Text;
                    if (regexinventory42.IsMatch(line)) { inventory42tb1.Text = line; }
                    inventory42tb2.Text = inventory42tb1.Text;
                    if (regexinventory43.IsMatch(line)) { inventory43tb1.Text = line; }
                    inventory43tb2.Text = inventory43tb1.Text;
                    if (regexinventory44.IsMatch(line)) { inventory44tb1.Text = line; }
                    inventory44tb2.Text = inventory44tb1.Text;
                    if (regexinventory45.IsMatch(line)) { inventory45tb1.Text = line; }
                    inventory45tb2.Text = inventory45tb1.Text;
                    if (regexinventory46.IsMatch(line)) { inventory46tb1.Text = line; }
                    inventory46tb2.Text = inventory46tb1.Text;
                    if (regexinventory47.IsMatch(line)) { inventory47tb1.Text = line; }
                    inventory47tb2.Text = inventory47tb1.Text;
                    if (regexinventory48.IsMatch(line)) { inventory48tb1.Text = line; }
                    inventory48tb2.Text = inventory48tb1.Text;
                    if (regexinventory49.IsMatch(line)) { inventory49tb1.Text = line; }
                    inventory49tb2.Text = inventory49tb1.Text;
                    if (regexinventory410.IsMatch(line)) { inventory410tb1.Text = line; }
                    inventory410tb2.Text = inventory410tb1.Text;
                    if (regexinventory411.IsMatch(line)) { inventory411tb1.Text = line; }
                    inventory411tb2.Text = inventory411tb1.Text;
                    if (regexinventory412.IsMatch(line)) { inventory412tb1.Text = line; }
                    inventory412tb2.Text = inventory412tb1.Text;
                    if (regexinventory413.IsMatch(line)) { inventory413tb1.Text = line; }
                    inventory413tb2.Text = inventory413tb1.Text;
                    if (regexinventory414.IsMatch(line)) { inventory414tb1.Text = line; }
                    inventory414tb2.Text = inventory414tb1.Text;
                    if (regexinventory415.IsMatch(line)) { inventory415tb1.Text = line; }
                    inventory415tb2.Text = inventory415tb1.Text;
                    if (regexinventory416.IsMatch(line)) { inventory416tb1.Text = line; }
                    inventory416tb2.Text = inventory416tb1.Text;
                    if (regexinventory417.IsMatch(line)) { inventory417tb1.Text = line; }
                    inventory417tb2.Text = inventory417tb1.Text;
                    if (regexinventory418.IsMatch(line)) { inventory418tb1.Text = line; }
                    inventory418tb2.Text = inventory418tb1.Text;
                    if (regexinventory419.IsMatch(line)) { inventory419tb1.Text = line; }
                    inventory419tb2.Text = inventory419tb1.Text;
                    if (regexinventory420.IsMatch(line)) { inventory420tb1.Text = line; }
                    inventory420tb2.Text = inventory420tb1.Text;
                    if (regexinventory421.IsMatch(line)) { inventory421tb1.Text = line; }
                    inventory421tb2.Text = inventory421tb1.Text;
                    if (regexinventory422.IsMatch(line)) { inventory422tb1.Text = line; }
                    inventory422tb2.Text = inventory422tb1.Text;
                    if (regexinventory423.IsMatch(line)) { inventory423tb1.Text = line; }
                    inventory423tb2.Text = inventory423tb1.Text;
                    if (regexinventory424.IsMatch(line)) { inventory424tb1.Text = line; }
                    inventory424tb2.Text = inventory424tb1.Text;
                    if (regexinventory425.IsMatch(line)) { inventory425tb1.Text = line; }
                    inventory425tb2.Text = inventory425tb1.Text;
                    if (regexinventory426.IsMatch(line)) { inventory426tb1.Text = line; }
                    inventory426tb2.Text = inventory426tb1.Text;
                    if (regexinventory427.IsMatch(line)) { inventory427tb1.Text = line; }
                    inventory427tb2.Text = inventory427tb1.Text;
                    if (regexinventory428.IsMatch(line)) { inventory428tb1.Text = line; }
                    inventory428tb2.Text = inventory428tb1.Text;
                    if (regexinventory429.IsMatch(line)) { inventory429tb1.Text = line; }
                    inventory429tb2.Text = inventory429tb1.Text;
                    if (regexinventory50.IsMatch(line)) { inventory50tb1.Text = line; }
                    inventory50tb2.Text = inventory50tb1.Text;
                    if (regexinventory51.IsMatch(line)) { inventory51tb1.Text = line; }
                    inventory51tb2.Text = inventory51tb1.Text;
                    if (regexinventory52.IsMatch(line)) { inventory52tb1.Text = line; }
                    inventory52tb2.Text = inventory52tb1.Text;
                    if (regexinventory53.IsMatch(line)) { inventory53tb1.Text = line; }
                    inventory53tb2.Text = inventory53tb1.Text;
                    if (regexinventory54.IsMatch(line)) { inventory54tb1.Text = line; }
                    inventory54tb2.Text = inventory54tb1.Text;
                    if (regexinventory55.IsMatch(line)) { inventory55tb1.Text = line; }
                    inventory55tb2.Text = inventory55tb1.Text;
                    if (regexinventory56.IsMatch(line)) { inventory56tb1.Text = line; }
                    inventory56tb2.Text = inventory56tb1.Text;
                    if (regexinventory57.IsMatch(line)) { inventory57tb1.Text = line; }
                    inventory57tb2.Text = inventory57tb1.Text;
                    if (regexinventory58.IsMatch(line)) { inventory58tb1.Text = line; }
                    inventory58tb2.Text = inventory58tb1.Text;
                    if (regexinventory59.IsMatch(line)) { inventory59tb1.Text = line; }
                    inventory59tb2.Text = inventory59tb1.Text;
                    if (regexinventory510.IsMatch(line)) { inventory510tb1.Text = line; }
                    inventory510tb2.Text = inventory510tb1.Text;
                    if (regexinventory511.IsMatch(line)) { inventory511tb1.Text = line; }
                    inventory511tb2.Text = inventory511tb1.Text;
                    if (regexinventory512.IsMatch(line)) { inventory512tb1.Text = line; }
                    inventory512tb2.Text = inventory512tb1.Text;
                    if (regexinventory513.IsMatch(line)) { inventory513tb1.Text = line; }
                    inventory513tb2.Text = inventory513tb1.Text;
                    if (regexinventory514.IsMatch(line)) { inventory514tb1.Text = line; }
                    inventory514tb2.Text = inventory514tb1.Text;
                    if (regexinventory515.IsMatch(line)) { inventory515tb1.Text = line; }
                    inventory515tb2.Text = inventory515tb1.Text;
                    if (regexinventory516.IsMatch(line)) { inventory516tb1.Text = line; }
                    inventory516tb2.Text = inventory516tb1.Text;
                    if (regexinventory517.IsMatch(line)) { inventory517tb1.Text = line; }
                    inventory517tb2.Text = inventory517tb1.Text;
                    if (regexinventory518.IsMatch(line)) { inventory518tb1.Text = line; }
                    inventory518tb2.Text = inventory518tb1.Text;
                    if (regexinventory519.IsMatch(line)) { inventory519tb1.Text = line; }
                    inventory519tb2.Text = inventory519tb1.Text;
                    if (regexinventory520.IsMatch(line)) { inventory520tb1.Text = line; }
                    inventory520tb2.Text = inventory520tb1.Text;
                    if (regexinventory521.IsMatch(line)) { inventory521tb1.Text = line; }
                    inventory521tb2.Text = inventory521tb1.Text;
                    if (regexinventory522.IsMatch(line)) { inventory522tb1.Text = line; }
                    inventory522tb2.Text = inventory522tb1.Text;
                    if (regexinventory523.IsMatch(line)) { inventory523tb1.Text = line; }
                    inventory523tb2.Text = inventory523tb1.Text;
                    if (regexinventory524.IsMatch(line)) { inventory524tb1.Text = line; }
                    inventory524tb2.Text = inventory524tb1.Text;
                    if (regexinventory525.IsMatch(line)) { inventory525tb1.Text = line; }
                    inventory525tb2.Text = inventory525tb1.Text;
                    if (regexinventory526.IsMatch(line)) { inventory526tb1.Text = line; }
                    inventory526tb2.Text = inventory526tb1.Text;
                    if (regexinventory527.IsMatch(line)) { inventory527tb1.Text = line; }
                    inventory527tb2.Text = inventory527tb1.Text;
                    if (regexinventory528.IsMatch(line)) { inventory528tb1.Text = line; }
                    inventory528tb2.Text = inventory528tb1.Text;
                    if (regexinventory529.IsMatch(line)) { inventory529tb1.Text = line; }
                    inventory529tb2.Text = inventory529tb1.Text;
                    if (regexinventory60.IsMatch(line)) { inventory60tb1.Text = line; }
                    inventory60tb2.Text = inventory60tb1.Text;
                    if (regexinventory61.IsMatch(line)) { inventory61tb1.Text = line; }
                    inventory61tb2.Text = inventory61tb1.Text;
                    if (regexinventory62.IsMatch(line)) { inventory62tb1.Text = line; }
                    inventory62tb2.Text = inventory62tb1.Text;
                    if (regexinventory63.IsMatch(line)) { inventory63tb1.Text = line; }
                    inventory63tb2.Text = inventory63tb1.Text;
                    if (regexinventory64.IsMatch(line)) { inventory64tb1.Text = line; }
                    inventory64tb2.Text = inventory64tb1.Text;
                    if (regexinventory65.IsMatch(line)) { inventory65tb1.Text = line; }
                    inventory65tb2.Text = inventory65tb1.Text;
                    if (regexinventory66.IsMatch(line)) { inventory66tb1.Text = line; }
                    inventory66tb2.Text = inventory66tb1.Text;
                    if (regexinventory67.IsMatch(line)) { inventory67tb1.Text = line; }
                    inventory67tb2.Text = inventory67tb1.Text;
                    if (regexinventory68.IsMatch(line)) { inventory68tb1.Text = line; }
                    inventory68tb2.Text = inventory68tb1.Text;
                    if (regexinventory69.IsMatch(line)) { inventory69tb1.Text = line; }
                    inventory69tb2.Text = inventory69tb1.Text;
                    if (regexinventory610.IsMatch(line)) { inventory610tb1.Text = line; }
                    inventory610tb2.Text = inventory610tb1.Text;
                    if (regexinventory611.IsMatch(line)) { inventory611tb1.Text = line; }
                    inventory611tb2.Text = inventory611tb1.Text;
                    if (regexinventory612.IsMatch(line)) { inventory612tb1.Text = line; }
                    inventory612tb2.Text = inventory612tb1.Text;
                    if (regexinventory613.IsMatch(line)) { inventory613tb1.Text = line; }
                    inventory613tb2.Text = inventory613tb1.Text;
                    if (regexinventory614.IsMatch(line)) { inventory614tb1.Text = line; }
                    inventory614tb2.Text = inventory614tb1.Text;
                    if (regexinventory615.IsMatch(line)) { inventory615tb1.Text = line; }
                    inventory615tb2.Text = inventory615tb1.Text;
                    if (regexinventory616.IsMatch(line)) { inventory616tb1.Text = line; }
                    inventory616tb2.Text = inventory616tb1.Text;
                    if (regexinventory617.IsMatch(line)) { inventory617tb1.Text = line; }
                    inventory617tb2.Text = inventory617tb1.Text;
                    if (regexinventory618.IsMatch(line)) { inventory618tb1.Text = line; }
                    inventory618tb2.Text = inventory618tb1.Text;
                    if (regexinventory619.IsMatch(line)) { inventory619tb1.Text = line; }
                    inventory619tb2.Text = inventory619tb1.Text;
                    if (regexinventory620.IsMatch(line)) { inventory620tb1.Text = line; }
                    inventory620tb2.Text = inventory620tb1.Text;
                    if (regexinventory621.IsMatch(line)) { inventory621tb1.Text = line; }
                    inventory621tb2.Text = inventory621tb1.Text;
                    if (regexinventory622.IsMatch(line)) { inventory622tb1.Text = line; }
                    inventory622tb2.Text = inventory622tb1.Text;
                    if (regexinventory623.IsMatch(line)) { inventory623tb1.Text = line; }
                    inventory623tb2.Text = inventory623tb1.Text;
                    if (regexinventory624.IsMatch(line)) { inventory624tb1.Text = line; }
                    inventory624tb2.Text = inventory624tb1.Text;
                    if (regexinventory625.IsMatch(line)) { inventory625tb1.Text = line; }
                    inventory625tb2.Text = inventory625tb1.Text;
                    if (regexinventory626.IsMatch(line)) { inventory626tb1.Text = line; }
                    inventory626tb2.Text = inventory626tb1.Text;
                    if (regexinventory627.IsMatch(line)) { inventory627tb1.Text = line; }
                    inventory627tb2.Text = inventory627tb1.Text;
                    if (regexinventory628.IsMatch(line)) { inventory628tb1.Text = line; }
                    inventory628tb2.Text = inventory628tb1.Text;
                    if (regexinventory629.IsMatch(line)) { inventory629tb1.Text = line; }
                    inventory629tb2.Text = inventory629tb1.Text;

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Hero_Siege", "save_folder", "herosiege17.pas");

            string name = File.ReadAllText(path);
            name = name.Replace(nametextbox1.Text, nametextbox2.Text);
            File.WriteAllText(path, name);
            string class1 = File.ReadAllText(path);
            class1 = class1.Replace(classtextbox1.Text, classtextbox2.Text);
            File.WriteAllText(path, class1);
            //string level = File.ReadAllText(path);
            //level = level.Replace(leveltextbox1.Text, leveltextbox2.Text);
            //File.WriteAllText(path, level);
            string strength = File.ReadAllText(path);
            strength = strength.Replace(strengthtextbox1.Text, strengthtextbox2.Text);
            File.WriteAllText(path, strength);
            string mana = File.ReadAllText(path);
            mana = mana.Replace(manatextbox1.Text, manatextbox2.Text);
            File.WriteAllText(path, mana);
            string armor = File.ReadAllText(path);
            armor = armor.Replace(armortextbox1.Text, armortextbox2.Text);
            File.WriteAllText(path, armor);
            string stamina = File.ReadAllText(path);
            stamina = stamina.Replace(staminatextbox1.Text, staminatextbox2.Text);
            File.WriteAllText(path, stamina);
            string wh = File.ReadAllText(path);
            wh = wh.Replace(whtb1.Text, whtb2.Text);
            File.WriteAllText(path, wh);
            string skill = File.ReadAllText(path);
            skill = skill.Replace(skilltb1.Text, skilltb2.Text);
            File.WriteAllText(path, skill);
            string talent = File.ReadAllText(path);
            talent = talent.Replace(talenttb1.Text, talenttb2.Text);
            File.WriteAllText(path, talent);
            string talent1 = File.ReadAllText(path);
            talent1 = talent1.Replace(talent1tb1.Text, talent1tb2.Text);
            File.WriteAllText(path, talent1);
            string talent2 = File.ReadAllText(path);
            talent2 = talent2.Replace(talent2tb1.Text, talent2tb2.Text);
            File.WriteAllText(path, talent2);
            string talent3 = File.ReadAllText(path);
            talent3 = talent3.Replace(talent3tb1.Text, talent3tb2.Text);
            File.WriteAllText(path, talent3);
            string talent4 = File.ReadAllText(path);
            talent4 = talent4.Replace(talent4tb1.Text, talent4tb2.Text);
            File.WriteAllText(path, talent4);
            string talent5 = File.ReadAllText(path);
            talent5 = talent5.Replace(talent5tb1.Text, talent5tb2.Text);
            File.WriteAllText(path, talent5);
            string talent6 = File.ReadAllText(path);
            talent6 = talent6.Replace(talent6tb1.Text, talent6tb2.Text);
            File.WriteAllText(path, talent6);
            string talent7 = File.ReadAllText(path);
            talent7 = talent7.Replace(talent7tb1.Text, talent7tb2.Text);
            File.WriteAllText(path, talent7);
            string talent8 = File.ReadAllText(path);
            talent8 = talent8.Replace(talent8tb1.Text, talent8tb2.Text);
            File.WriteAllText(path, talent8);
            string talent9 = File.ReadAllText(path);
            talent9 = talent9.Replace(talent9tb1.Text, talent9tb2.Text);
            File.WriteAllText(path, talent9);
            string inventory00 = File.ReadAllText(path);
            inventory00 = inventory00.Replace(inventory00tb1.Text, inventory00tb2.Text);
            File.WriteAllText(path, inventory00);
            string inventory01 = File.ReadAllText(path);
            inventory01 = inventory01.Replace(inventory01tb1.Text, inventory01tb2.Text);
            File.WriteAllText(path, inventory01);
            string inventory02 = File.ReadAllText(path);
            inventory02 = inventory02.Replace(inventory02tb1.Text, inventory02tb2.Text);
            File.WriteAllText(path, inventory02);
            string inventory03 = File.ReadAllText(path);
            inventory03 = inventory03.Replace(inventory03tb1.Text, inventory03tb2.Text);
            File.WriteAllText(path, inventory03);
            string inventory04 = File.ReadAllText(path);
            inventory04 = inventory04.Replace(inventory04tb1.Text, inventory04tb2.Text);
            File.WriteAllText(path, inventory04);
            string inventory05 = File.ReadAllText(path);
            inventory05 = inventory05.Replace(inventory05tb1.Text, inventory05tb2.Text);
            File.WriteAllText(path, inventory05);
            string inventory06 = File.ReadAllText(path);
            inventory06 = inventory06.Replace(inventory06tb1.Text, inventory06tb2.Text);
            File.WriteAllText(path, inventory06);
            string inventory07 = File.ReadAllText(path);
            inventory07 = inventory07.Replace(inventory07tb1.Text, inventory07tb2.Text);
            File.WriteAllText(path, inventory07);
            string inventory08 = File.ReadAllText(path);
            inventory08 = inventory08.Replace(inventory08tb1.Text, inventory08tb2.Text);
            File.WriteAllText(path, inventory08);
            string inventory09 = File.ReadAllText(path);
            inventory09 = inventory09.Replace(inventory09tb1.Text, inventory09tb2.Text);
            File.WriteAllText(path, inventory09);
            string inventory010 = File.ReadAllText(path);
            inventory010 = inventory010.Replace(inventory010tb1.Text, inventory010tb2.Text);
            File.WriteAllText(path, inventory010);
            string inventory011 = File.ReadAllText(path);
            inventory011 = inventory011.Replace(inventory011tb1.Text, inventory011tb2.Text);
            File.WriteAllText(path, inventory011);
            string inventory012 = File.ReadAllText(path);
            inventory012 = inventory012.Replace(inventory012tb1.Text, inventory012tb2.Text);
            File.WriteAllText(path, inventory012);
            string inventory013 = File.ReadAllText(path);
            inventory013 = inventory013.Replace(inventory013tb1.Text, inventory013tb2.Text);
            File.WriteAllText(path, inventory013);
            string inventory014 = File.ReadAllText(path);
            inventory014 = inventory014.Replace(inventory014tb1.Text, inventory014tb2.Text);
            File.WriteAllText(path, inventory014);
            string inventory015 = File.ReadAllText(path);
            inventory015 = inventory015.Replace(inventory015tb1.Text, inventory015tb2.Text);
            File.WriteAllText(path, inventory015);
            string inventory016 = File.ReadAllText(path);
            inventory016 = inventory016.Replace(inventory016tb1.Text, inventory016tb2.Text);
            File.WriteAllText(path, inventory016);
            string inventory017 = File.ReadAllText(path);
            inventory017 = inventory017.Replace(inventory017tb1.Text, inventory017tb2.Text);
            File.WriteAllText(path, inventory017);
            string inventory018 = File.ReadAllText(path);
            inventory018 = inventory018.Replace(inventory018tb1.Text, inventory018tb2.Text);
            File.WriteAllText(path, inventory018);
            string inventory019 = File.ReadAllText(path);
            inventory019 = inventory019.Replace(inventory019tb1.Text, inventory019tb2.Text);
            File.WriteAllText(path, inventory019);
            string inventory020 = File.ReadAllText(path);
            inventory020 = inventory020.Replace(inventory020tb1.Text, inventory020tb2.Text);
            File.WriteAllText(path, inventory020);
            string inventory021 = File.ReadAllText(path);
            inventory021 = inventory021.Replace(inventory021tb1.Text, inventory021tb2.Text);
            File.WriteAllText(path, inventory021);
            string inventory022 = File.ReadAllText(path);
            inventory022 = inventory022.Replace(inventory022tb1.Text, inventory022tb2.Text);
            File.WriteAllText(path, inventory022);
            string inventory023 = File.ReadAllText(path);
            inventory023 = inventory023.Replace(inventory023tb1.Text, inventory023tb2.Text);
            File.WriteAllText(path, inventory023);
            string inventory024 = File.ReadAllText(path);
            inventory024 = inventory024.Replace(inventory024tb1.Text, inventory024tb2.Text);
            File.WriteAllText(path, inventory024);
            string inventory025 = File.ReadAllText(path);
            inventory025 = inventory025.Replace(inventory025tb1.Text, inventory025tb2.Text);
            File.WriteAllText(path, inventory025);
            string inventory026 = File.ReadAllText(path);
            inventory026 = inventory026.Replace(inventory026tb1.Text, inventory026tb2.Text);
            File.WriteAllText(path, inventory026);
            string inventory027 = File.ReadAllText(path);
            inventory027 = inventory027.Replace(inventory027tb1.Text, inventory027tb2.Text);
            File.WriteAllText(path, inventory027);
            string inventory028 = File.ReadAllText(path);
            inventory028 = inventory028.Replace(inventory028tb1.Text, inventory028tb2.Text);
            File.WriteAllText(path, inventory028);
            string inventory029 = File.ReadAllText(path);
            inventory029 = inventory029.Replace(inventory029tb1.Text, inventory029tb2.Text);
            File.WriteAllText(path, inventory029);
            string inventory10 = File.ReadAllText(path);
            inventory10 = inventory10.Replace(inventory10tb1.Text, inventory10tb2.Text);
            File.WriteAllText(path, inventory10);
            string inventory11 = File.ReadAllText(path);
            inventory11 = inventory11.Replace(inventory11tb1.Text, inventory11tb2.Text);
            File.WriteAllText(path, inventory11);
            string inventory12 = File.ReadAllText(path);
            inventory12 = inventory12.Replace(inventory12tb1.Text, inventory12tb2.Text);
            File.WriteAllText(path, inventory12);
            string inventory13 = File.ReadAllText(path);
            inventory13 = inventory13.Replace(inventory13tb1.Text, inventory13tb2.Text);
            File.WriteAllText(path, inventory13);
            string inventory14 = File.ReadAllText(path);
            inventory14 = inventory14.Replace(inventory14tb1.Text, inventory14tb2.Text);
            File.WriteAllText(path, inventory14);
            string inventory15 = File.ReadAllText(path);
            inventory15 = inventory15.Replace(inventory15tb1.Text, inventory15tb2.Text);
            File.WriteAllText(path, inventory15);
            string inventory16 = File.ReadAllText(path);
            inventory16 = inventory16.Replace(inventory16tb1.Text, inventory16tb2.Text);
            File.WriteAllText(path, inventory16);
            string inventory17 = File.ReadAllText(path);
            inventory17 = inventory17.Replace(inventory17tb1.Text, inventory17tb2.Text);
            File.WriteAllText(path, inventory17);
            string inventory18 = File.ReadAllText(path);
            inventory18 = inventory18.Replace(inventory18tb1.Text, inventory18tb2.Text);
            File.WriteAllText(path, inventory18);
            string inventory19 = File.ReadAllText(path);
            inventory19 = inventory19.Replace(inventory19tb1.Text, inventory19tb2.Text);
            File.WriteAllText(path, inventory19);
            string inventory110 = File.ReadAllText(path);
            inventory110 = inventory110.Replace(inventory110tb1.Text, inventory110tb2.Text);
            File.WriteAllText(path, inventory110);
            string inventory111 = File.ReadAllText(path);
            inventory111 = inventory111.Replace(inventory111tb1.Text, inventory111tb2.Text);
            File.WriteAllText(path, inventory111);
            string inventory112 = File.ReadAllText(path);
            inventory112 = inventory112.Replace(inventory112tb1.Text, inventory112tb2.Text);
            File.WriteAllText(path, inventory112);
            string inventory113 = File.ReadAllText(path);
            inventory113 = inventory113.Replace(inventory113tb1.Text, inventory113tb2.Text);
            File.WriteAllText(path, inventory113);
            string inventory114 = File.ReadAllText(path);
            inventory114 = inventory114.Replace(inventory114tb1.Text, inventory114tb2.Text);
            File.WriteAllText(path, inventory114);
            string inventory115 = File.ReadAllText(path);
            inventory115 = inventory115.Replace(inventory115tb1.Text, inventory115tb2.Text);
            File.WriteAllText(path, inventory115);
            string inventory116 = File.ReadAllText(path);
            inventory116 = inventory116.Replace(inventory116tb1.Text, inventory116tb2.Text);
            File.WriteAllText(path, inventory116);
            string inventory117 = File.ReadAllText(path);
            inventory117 = inventory117.Replace(inventory117tb1.Text, inventory117tb2.Text);
            File.WriteAllText(path, inventory117);
            string inventory118 = File.ReadAllText(path);
            inventory118 = inventory118.Replace(inventory118tb1.Text, inventory118tb2.Text);
            File.WriteAllText(path, inventory118);
            string inventory119 = File.ReadAllText(path);
            inventory119 = inventory119.Replace(inventory119tb1.Text, inventory119tb2.Text);
            File.WriteAllText(path, inventory119);
            string inventory120 = File.ReadAllText(path);
            inventory120 = inventory120.Replace(inventory120tb1.Text, inventory120tb2.Text);
            File.WriteAllText(path, inventory120);
            string inventory121 = File.ReadAllText(path);
            inventory121 = inventory121.Replace(inventory121tb1.Text, inventory121tb2.Text);
            File.WriteAllText(path, inventory121);
            string inventory122 = File.ReadAllText(path);
            inventory122 = inventory122.Replace(inventory122tb1.Text, inventory122tb2.Text);
            File.WriteAllText(path, inventory122);
            string inventory123 = File.ReadAllText(path);
            inventory123 = inventory123.Replace(inventory123tb1.Text, inventory123tb2.Text);
            File.WriteAllText(path, inventory123);
            string inventory124 = File.ReadAllText(path);
            inventory124 = inventory124.Replace(inventory124tb1.Text, inventory124tb2.Text);
            File.WriteAllText(path, inventory124);
            string inventory125 = File.ReadAllText(path);
            inventory125 = inventory125.Replace(inventory125tb1.Text, inventory125tb2.Text);
            File.WriteAllText(path, inventory125);
            string inventory126 = File.ReadAllText(path);
            inventory126 = inventory126.Replace(inventory126tb1.Text, inventory126tb2.Text);
            File.WriteAllText(path, inventory126);
            string inventory127 = File.ReadAllText(path);
            inventory127 = inventory127.Replace(inventory127tb1.Text, inventory127tb2.Text);
            File.WriteAllText(path, inventory127);
            string inventory128 = File.ReadAllText(path);
            inventory128 = inventory128.Replace(inventory128tb1.Text, inventory128tb2.Text);
            File.WriteAllText(path, inventory128);
            string inventory129 = File.ReadAllText(path);
            inventory129 = inventory129.Replace(inventory129tb1.Text, inventory129tb2.Text);
            File.WriteAllText(path, inventory129);
            string inventory20 = File.ReadAllText(path);
            inventory20 = inventory20.Replace(inventory20tb1.Text, inventory20tb2.Text);
            File.WriteAllText(path, inventory20);
            string inventory21 = File.ReadAllText(path);
            inventory21 = inventory21.Replace(inventory21tb1.Text, inventory21tb2.Text);
            File.WriteAllText(path, inventory21);
            string inventory22 = File.ReadAllText(path);
            inventory22 = inventory22.Replace(inventory22tb1.Text, inventory22tb2.Text);
            File.WriteAllText(path, inventory22);
            string inventory23 = File.ReadAllText(path);
            inventory23 = inventory23.Replace(inventory23tb1.Text, inventory23tb2.Text);
            File.WriteAllText(path, inventory23);
            string inventory24 = File.ReadAllText(path);
            inventory24 = inventory24.Replace(inventory24tb1.Text, inventory24tb2.Text);
            File.WriteAllText(path, inventory24);
            string inventory25 = File.ReadAllText(path);
            inventory25 = inventory25.Replace(inventory25tb1.Text, inventory25tb2.Text);
            File.WriteAllText(path, inventory25);
            string inventory26 = File.ReadAllText(path);
            inventory26 = inventory26.Replace(inventory26tb1.Text, inventory26tb2.Text);
            File.WriteAllText(path, inventory26);
            string inventory27 = File.ReadAllText(path);
            inventory27 = inventory27.Replace(inventory27tb1.Text, inventory27tb2.Text);
            File.WriteAllText(path, inventory27);
            string inventory28 = File.ReadAllText(path);
            inventory28 = inventory28.Replace(inventory28tb1.Text, inventory28tb2.Text);
            File.WriteAllText(path, inventory28);
            string inventory29 = File.ReadAllText(path);
            inventory29 = inventory29.Replace(inventory29tb1.Text, inventory29tb2.Text);
            File.WriteAllText(path, inventory29);
            string inventory210 = File.ReadAllText(path);
            inventory210 = inventory210.Replace(inventory210tb1.Text, inventory210tb2.Text);
            File.WriteAllText(path, inventory210);
            string inventory211 = File.ReadAllText(path);
            inventory211 = inventory211.Replace(inventory211tb1.Text, inventory211tb2.Text);
            File.WriteAllText(path, inventory211);
            string inventory212 = File.ReadAllText(path);
            inventory212 = inventory212.Replace(inventory212tb1.Text, inventory212tb2.Text);
            File.WriteAllText(path, inventory212);
            string inventory213 = File.ReadAllText(path);
            inventory213 = inventory213.Replace(inventory213tb1.Text, inventory213tb2.Text);
            File.WriteAllText(path, inventory213);
            string inventory214 = File.ReadAllText(path);
            inventory214 = inventory214.Replace(inventory214tb1.Text, inventory214tb2.Text);
            File.WriteAllText(path, inventory214);
            string inventory215 = File.ReadAllText(path);
            inventory215 = inventory215.Replace(inventory215tb1.Text, inventory215tb2.Text);
            File.WriteAllText(path, inventory215);
            string inventory216 = File.ReadAllText(path);
            inventory216 = inventory216.Replace(inventory216tb1.Text, inventory216tb2.Text);
            File.WriteAllText(path, inventory216);
            string inventory217 = File.ReadAllText(path);
            inventory217 = inventory217.Replace(inventory217tb1.Text, inventory217tb2.Text);
            File.WriteAllText(path, inventory217);
            string inventory218 = File.ReadAllText(path);
            inventory218 = inventory218.Replace(inventory218tb1.Text, inventory218tb2.Text);
            File.WriteAllText(path, inventory218);
            string inventory219 = File.ReadAllText(path);
            inventory219 = inventory219.Replace(inventory219tb1.Text, inventory219tb2.Text);
            File.WriteAllText(path, inventory219);
            string inventory220 = File.ReadAllText(path);
            inventory220 = inventory220.Replace(inventory220tb1.Text, inventory220tb2.Text);
            File.WriteAllText(path, inventory220);
            string inventory221 = File.ReadAllText(path);
            inventory221 = inventory221.Replace(inventory221tb1.Text, inventory221tb2.Text);
            File.WriteAllText(path, inventory221);
            string inventory222 = File.ReadAllText(path);
            inventory222 = inventory222.Replace(inventory222tb1.Text, inventory222tb2.Text);
            File.WriteAllText(path, inventory222);
            string inventory223 = File.ReadAllText(path);
            inventory223 = inventory223.Replace(inventory223tb1.Text, inventory223tb2.Text);
            File.WriteAllText(path, inventory223);
            string inventory224 = File.ReadAllText(path);
            inventory224 = inventory224.Replace(inventory224tb1.Text, inventory224tb2.Text);
            File.WriteAllText(path, inventory224);
            string inventory225 = File.ReadAllText(path);
            inventory225 = inventory225.Replace(inventory225tb1.Text, inventory225tb2.Text);
            File.WriteAllText(path, inventory225);
            string inventory226 = File.ReadAllText(path);
            inventory226 = inventory226.Replace(inventory226tb1.Text, inventory226tb2.Text);
            File.WriteAllText(path, inventory226);
            string inventory227 = File.ReadAllText(path);
            inventory227 = inventory227.Replace(inventory227tb1.Text, inventory227tb2.Text);
            File.WriteAllText(path, inventory227);
            string inventory228 = File.ReadAllText(path);
            inventory228 = inventory228.Replace(inventory228tb1.Text, inventory228tb2.Text);
            File.WriteAllText(path, inventory228);
            string inventory229 = File.ReadAllText(path);
            inventory229 = inventory229.Replace(inventory229tb1.Text, inventory229tb2.Text);
            File.WriteAllText(path, inventory229);
            string inventory30 = File.ReadAllText(path);
            inventory30 = inventory30.Replace(inventory30tb1.Text, inventory30tb2.Text);
            File.WriteAllText(path, inventory30);
            string inventory31 = File.ReadAllText(path);
            inventory31 = inventory31.Replace(inventory31tb1.Text, inventory31tb2.Text);
            File.WriteAllText(path, inventory31);
            string inventory32 = File.ReadAllText(path);
            inventory32 = inventory32.Replace(inventory32tb1.Text, inventory32tb2.Text);
            File.WriteAllText(path, inventory32);
            string inventory33 = File.ReadAllText(path);
            inventory33 = inventory33.Replace(inventory33tb1.Text, inventory33tb2.Text);
            File.WriteAllText(path, inventory33);
            string inventory34 = File.ReadAllText(path);
            inventory34 = inventory34.Replace(inventory34tb1.Text, inventory34tb2.Text);
            File.WriteAllText(path, inventory34);
            string inventory35 = File.ReadAllText(path);
            inventory35 = inventory35.Replace(inventory35tb1.Text, inventory35tb2.Text);
            File.WriteAllText(path, inventory35);
            string inventory36 = File.ReadAllText(path);
            inventory36 = inventory36.Replace(inventory36tb1.Text, inventory36tb2.Text);
            File.WriteAllText(path, inventory36);
            string inventory37 = File.ReadAllText(path);
            inventory37 = inventory37.Replace(inventory37tb1.Text, inventory37tb2.Text);
            File.WriteAllText(path, inventory37);
            string inventory38 = File.ReadAllText(path);
            inventory38 = inventory38.Replace(inventory38tb1.Text, inventory38tb2.Text);
            File.WriteAllText(path, inventory38);
            string inventory39 = File.ReadAllText(path);
            inventory39 = inventory39.Replace(inventory39tb1.Text, inventory39tb2.Text);
            File.WriteAllText(path, inventory39);
            string inventory310 = File.ReadAllText(path);
            inventory310 = inventory310.Replace(inventory310tb1.Text, inventory310tb2.Text);
            File.WriteAllText(path, inventory310);
            string inventory311 = File.ReadAllText(path);
            inventory311 = inventory311.Replace(inventory311tb1.Text, inventory311tb2.Text);
            File.WriteAllText(path, inventory311);
            string inventory312 = File.ReadAllText(path);
            inventory312 = inventory312.Replace(inventory312tb1.Text, inventory312tb2.Text);
            File.WriteAllText(path, inventory312);
            string inventory313 = File.ReadAllText(path);
            inventory313 = inventory313.Replace(inventory313tb1.Text, inventory313tb2.Text);
            File.WriteAllText(path, inventory313);
            string inventory314 = File.ReadAllText(path);
            inventory314 = inventory314.Replace(inventory314tb1.Text, inventory314tb2.Text);
            File.WriteAllText(path, inventory314);
            string inventory315 = File.ReadAllText(path);
            inventory315 = inventory315.Replace(inventory315tb1.Text, inventory315tb2.Text);
            File.WriteAllText(path, inventory315);
            string inventory316 = File.ReadAllText(path);
            inventory316 = inventory316.Replace(inventory316tb1.Text, inventory316tb2.Text);
            File.WriteAllText(path, inventory316);
            string inventory317 = File.ReadAllText(path);
            inventory317 = inventory317.Replace(inventory317tb1.Text, inventory317tb2.Text);
            File.WriteAllText(path, inventory317);
            string inventory318 = File.ReadAllText(path);
            inventory318 = inventory318.Replace(inventory318tb1.Text, inventory318tb2.Text);
            File.WriteAllText(path, inventory318);
            string inventory319 = File.ReadAllText(path);
            inventory319 = inventory319.Replace(inventory319tb1.Text, inventory319tb2.Text);
            File.WriteAllText(path, inventory319);
            string inventory320 = File.ReadAllText(path);
            inventory320 = inventory320.Replace(inventory320tb1.Text, inventory320tb2.Text);
            File.WriteAllText(path, inventory320);
            string inventory321 = File.ReadAllText(path);
            inventory321 = inventory321.Replace(inventory321tb1.Text, inventory321tb2.Text);
            File.WriteAllText(path, inventory321);
            string inventory322 = File.ReadAllText(path);
            inventory322 = inventory322.Replace(inventory322tb1.Text, inventory322tb2.Text);
            File.WriteAllText(path, inventory322);
            string inventory323 = File.ReadAllText(path);
            inventory323 = inventory323.Replace(inventory323tb1.Text, inventory323tb2.Text);
            File.WriteAllText(path, inventory323);
            string inventory324 = File.ReadAllText(path);
            inventory324 = inventory324.Replace(inventory324tb1.Text, inventory324tb2.Text);
            File.WriteAllText(path, inventory324);
            string inventory325 = File.ReadAllText(path);
            inventory325 = inventory325.Replace(inventory325tb1.Text, inventory325tb2.Text);
            File.WriteAllText(path, inventory325);
            string inventory326 = File.ReadAllText(path);
            inventory326 = inventory326.Replace(inventory326tb1.Text, inventory326tb2.Text);
            File.WriteAllText(path, inventory326);
            string inventory327 = File.ReadAllText(path);
            inventory327 = inventory327.Replace(inventory327tb1.Text, inventory327tb2.Text);
            File.WriteAllText(path, inventory327);
            string inventory328 = File.ReadAllText(path);
            inventory328 = inventory328.Replace(inventory328tb1.Text, inventory328tb2.Text);
            File.WriteAllText(path, inventory328);
            string inventory329 = File.ReadAllText(path);
            inventory329 = inventory329.Replace(inventory329tb1.Text, inventory329tb2.Text);
            File.WriteAllText(path, inventory329);
            string inventory40 = File.ReadAllText(path);
            inventory40 = inventory40.Replace(inventory40tb1.Text, inventory40tb2.Text);
            File.WriteAllText(path, inventory40);
            string inventory41 = File.ReadAllText(path);
            inventory41 = inventory41.Replace(inventory41tb1.Text, inventory41tb2.Text);
            File.WriteAllText(path, inventory41);
            string inventory42 = File.ReadAllText(path);
            inventory42 = inventory42.Replace(inventory42tb1.Text, inventory42tb2.Text);
            File.WriteAllText(path, inventory42);
            string inventory43 = File.ReadAllText(path);
            inventory43 = inventory43.Replace(inventory43tb1.Text, inventory43tb2.Text);
            File.WriteAllText(path, inventory43);
            string inventory44 = File.ReadAllText(path);
            inventory44 = inventory44.Replace(inventory44tb1.Text, inventory44tb2.Text);
            File.WriteAllText(path, inventory44);
            string inventory45 = File.ReadAllText(path);
            inventory45 = inventory45.Replace(inventory45tb1.Text, inventory45tb2.Text);
            File.WriteAllText(path, inventory45);
            string inventory46 = File.ReadAllText(path);
            inventory46 = inventory46.Replace(inventory46tb1.Text, inventory46tb2.Text);
            File.WriteAllText(path, inventory46);
            string inventory47 = File.ReadAllText(path);
            inventory47 = inventory47.Replace(inventory47tb1.Text, inventory47tb2.Text);
            File.WriteAllText(path, inventory47);
            string inventory48 = File.ReadAllText(path);
            inventory48 = inventory48.Replace(inventory48tb1.Text, inventory48tb2.Text);
            File.WriteAllText(path, inventory48);
            string inventory49 = File.ReadAllText(path);
            inventory49 = inventory49.Replace(inventory49tb1.Text, inventory49tb2.Text);
            File.WriteAllText(path, inventory49);
            string inventory410 = File.ReadAllText(path);
            inventory410 = inventory410.Replace(inventory410tb1.Text, inventory410tb2.Text);
            File.WriteAllText(path, inventory410);
            string inventory411 = File.ReadAllText(path);
            inventory411 = inventory411.Replace(inventory411tb1.Text, inventory411tb2.Text);
            File.WriteAllText(path, inventory411);
            string inventory412 = File.ReadAllText(path);
            inventory412 = inventory412.Replace(inventory412tb1.Text, inventory412tb2.Text);
            File.WriteAllText(path, inventory412);
            string inventory413 = File.ReadAllText(path);
            inventory413 = inventory413.Replace(inventory413tb1.Text, inventory413tb2.Text);
            File.WriteAllText(path, inventory413);
            string inventory414 = File.ReadAllText(path);
            inventory414 = inventory414.Replace(inventory414tb1.Text, inventory414tb2.Text);
            File.WriteAllText(path, inventory414);
            string inventory415 = File.ReadAllText(path);
            inventory415 = inventory415.Replace(inventory415tb1.Text, inventory415tb2.Text);
            File.WriteAllText(path, inventory415);
            string inventory416 = File.ReadAllText(path);
            inventory416 = inventory416.Replace(inventory416tb1.Text, inventory416tb2.Text);
            File.WriteAllText(path, inventory416);
            string inventory417 = File.ReadAllText(path);
            inventory417 = inventory417.Replace(inventory417tb1.Text, inventory417tb2.Text);
            File.WriteAllText(path, inventory417);
            string inventory418 = File.ReadAllText(path);
            inventory418 = inventory418.Replace(inventory418tb1.Text, inventory418tb2.Text);
            File.WriteAllText(path, inventory418);
            string inventory419 = File.ReadAllText(path);
            inventory419 = inventory419.Replace(inventory419tb1.Text, inventory419tb2.Text);
            File.WriteAllText(path, inventory419);
            string inventory420 = File.ReadAllText(path);
            inventory420 = inventory420.Replace(inventory420tb1.Text, inventory420tb2.Text);
            File.WriteAllText(path, inventory420);
            string inventory421 = File.ReadAllText(path);
            inventory421 = inventory421.Replace(inventory421tb1.Text, inventory421tb2.Text);
            File.WriteAllText(path, inventory421);
            string inventory422 = File.ReadAllText(path);
            inventory422 = inventory422.Replace(inventory422tb1.Text, inventory422tb2.Text);
            File.WriteAllText(path, inventory422);
            string inventory423 = File.ReadAllText(path);
            inventory423 = inventory423.Replace(inventory423tb1.Text, inventory423tb2.Text);
            File.WriteAllText(path, inventory423);
            string inventory424 = File.ReadAllText(path);
            inventory424 = inventory424.Replace(inventory424tb1.Text, inventory424tb2.Text);
            File.WriteAllText(path, inventory424);
            string inventory425 = File.ReadAllText(path);
            inventory425 = inventory425.Replace(inventory425tb1.Text, inventory425tb2.Text);
            File.WriteAllText(path, inventory425);
            string inventory426 = File.ReadAllText(path);
            inventory426 = inventory426.Replace(inventory426tb1.Text, inventory426tb2.Text);
            File.WriteAllText(path, inventory426);
            string inventory427 = File.ReadAllText(path);
            inventory427 = inventory427.Replace(inventory427tb1.Text, inventory427tb2.Text);
            File.WriteAllText(path, inventory427);
            string inventory428 = File.ReadAllText(path);
            inventory428 = inventory428.Replace(inventory428tb1.Text, inventory428tb2.Text);
            File.WriteAllText(path, inventory428);
            string inventory429 = File.ReadAllText(path);
            inventory429 = inventory429.Replace(inventory429tb1.Text, inventory429tb2.Text);
            File.WriteAllText(path, inventory429);
            string inventory50 = File.ReadAllText(path);
            inventory50 = inventory50.Replace(inventory50tb1.Text, inventory50tb2.Text);
            File.WriteAllText(path, inventory50);
            string inventory51 = File.ReadAllText(path);
            inventory51 = inventory51.Replace(inventory51tb1.Text, inventory51tb2.Text);
            File.WriteAllText(path, inventory51);
            string inventory52 = File.ReadAllText(path);
            inventory52 = inventory52.Replace(inventory52tb1.Text, inventory52tb2.Text);
            File.WriteAllText(path, inventory52);
            string inventory53 = File.ReadAllText(path);
            inventory53 = inventory53.Replace(inventory53tb1.Text, inventory53tb2.Text);
            File.WriteAllText(path, inventory53);
            string inventory54 = File.ReadAllText(path);
            inventory54 = inventory54.Replace(inventory54tb1.Text, inventory54tb2.Text);
            File.WriteAllText(path, inventory54);
            string inventory55 = File.ReadAllText(path);
            inventory55 = inventory55.Replace(inventory55tb1.Text, inventory55tb2.Text);
            File.WriteAllText(path, inventory55);
            string inventory56 = File.ReadAllText(path);
            inventory56 = inventory56.Replace(inventory56tb1.Text, inventory56tb2.Text);
            File.WriteAllText(path, inventory56);
            string inventory57 = File.ReadAllText(path);
            inventory57 = inventory57.Replace(inventory57tb1.Text, inventory57tb2.Text);
            File.WriteAllText(path, inventory57);
            string inventory58 = File.ReadAllText(path);
            inventory58 = inventory58.Replace(inventory58tb1.Text, inventory58tb2.Text);
            File.WriteAllText(path, inventory58);
            string inventory59 = File.ReadAllText(path);
            inventory59 = inventory59.Replace(inventory59tb1.Text, inventory59tb2.Text);
            File.WriteAllText(path, inventory59);
            string inventory510 = File.ReadAllText(path);
            inventory510 = inventory510.Replace(inventory510tb1.Text, inventory510tb2.Text);
            File.WriteAllText(path, inventory510);
            string inventory511 = File.ReadAllText(path);
            inventory511 = inventory511.Replace(inventory511tb1.Text, inventory511tb2.Text);
            File.WriteAllText(path, inventory511);
            string inventory512 = File.ReadAllText(path);
            inventory512 = inventory512.Replace(inventory512tb1.Text, inventory512tb2.Text);
            File.WriteAllText(path, inventory512);
            string inventory513 = File.ReadAllText(path);
            inventory513 = inventory513.Replace(inventory513tb1.Text, inventory513tb2.Text);
            File.WriteAllText(path, inventory513);
            string inventory514 = File.ReadAllText(path);
            inventory514 = inventory514.Replace(inventory514tb1.Text, inventory514tb2.Text);
            File.WriteAllText(path, inventory514);
            string inventory515 = File.ReadAllText(path);
            inventory515 = inventory515.Replace(inventory515tb1.Text, inventory515tb2.Text);
            File.WriteAllText(path, inventory515);
            string inventory516 = File.ReadAllText(path);
            inventory516 = inventory516.Replace(inventory516tb1.Text, inventory516tb2.Text);
            File.WriteAllText(path, inventory516);
            string inventory517 = File.ReadAllText(path);
            inventory517 = inventory517.Replace(inventory517tb1.Text, inventory517tb2.Text);
            File.WriteAllText(path, inventory517);
            string inventory518 = File.ReadAllText(path);
            inventory518 = inventory518.Replace(inventory518tb1.Text, inventory518tb2.Text);
            File.WriteAllText(path, inventory518);
            string inventory519 = File.ReadAllText(path);
            inventory519 = inventory519.Replace(inventory519tb1.Text, inventory519tb2.Text);
            File.WriteAllText(path, inventory519);
            string inventory520 = File.ReadAllText(path);
            inventory520 = inventory520.Replace(inventory520tb1.Text, inventory520tb2.Text);
            File.WriteAllText(path, inventory520);
            string inventory521 = File.ReadAllText(path);
            inventory521 = inventory521.Replace(inventory521tb1.Text, inventory521tb2.Text);
            File.WriteAllText(path, inventory521);
            string inventory522 = File.ReadAllText(path);
            inventory522 = inventory522.Replace(inventory522tb1.Text, inventory522tb2.Text);
            File.WriteAllText(path, inventory522);
            string inventory523 = File.ReadAllText(path);
            inventory523 = inventory523.Replace(inventory523tb1.Text, inventory523tb2.Text);
            File.WriteAllText(path, inventory523);
            string inventory524 = File.ReadAllText(path);
            inventory524 = inventory524.Replace(inventory524tb1.Text, inventory524tb2.Text);
            File.WriteAllText(path, inventory524);
            string inventory525 = File.ReadAllText(path);
            inventory525 = inventory525.Replace(inventory525tb1.Text, inventory525tb2.Text);
            File.WriteAllText(path, inventory525);
            string inventory526 = File.ReadAllText(path);
            inventory526 = inventory526.Replace(inventory526tb1.Text, inventory526tb2.Text);
            File.WriteAllText(path, inventory526);
            string inventory527 = File.ReadAllText(path);
            inventory527 = inventory527.Replace(inventory527tb1.Text, inventory527tb2.Text);
            File.WriteAllText(path, inventory527);
            string inventory528 = File.ReadAllText(path);
            inventory528 = inventory528.Replace(inventory528tb1.Text, inventory528tb2.Text);
            File.WriteAllText(path, inventory528);
            string inventory529 = File.ReadAllText(path);
            inventory529 = inventory529.Replace(inventory529tb1.Text, inventory529tb2.Text);
            File.WriteAllText(path, inventory529);
            string inventory60 = File.ReadAllText(path);
            inventory60 = inventory60.Replace(inventory60tb1.Text, inventory60tb2.Text);
            File.WriteAllText(path, inventory60);
            string inventory61 = File.ReadAllText(path);
            inventory61 = inventory61.Replace(inventory61tb1.Text, inventory61tb2.Text);
            File.WriteAllText(path, inventory61);
            string inventory62 = File.ReadAllText(path);
            inventory62 = inventory62.Replace(inventory62tb1.Text, inventory62tb2.Text);
            File.WriteAllText(path, inventory62);
            string inventory63 = File.ReadAllText(path);
            inventory63 = inventory63.Replace(inventory63tb1.Text, inventory63tb2.Text);
            File.WriteAllText(path, inventory63);
            string inventory64 = File.ReadAllText(path);
            inventory64 = inventory64.Replace(inventory64tb1.Text, inventory64tb2.Text);
            File.WriteAllText(path, inventory64);
            string inventory65 = File.ReadAllText(path);
            inventory65 = inventory65.Replace(inventory65tb1.Text, inventory65tb2.Text);
            File.WriteAllText(path, inventory65);
            string inventory66 = File.ReadAllText(path);
            inventory66 = inventory66.Replace(inventory66tb1.Text, inventory66tb2.Text);
            File.WriteAllText(path, inventory66);
            string inventory67 = File.ReadAllText(path);
            inventory67 = inventory67.Replace(inventory67tb1.Text, inventory67tb2.Text);
            File.WriteAllText(path, inventory67);
            string inventory68 = File.ReadAllText(path);
            inventory68 = inventory68.Replace(inventory68tb1.Text, inventory68tb2.Text);
            File.WriteAllText(path, inventory68);
            string inventory69 = File.ReadAllText(path);
            inventory69 = inventory69.Replace(inventory69tb1.Text, inventory69tb2.Text);
            File.WriteAllText(path, inventory69);
            string inventory610 = File.ReadAllText(path);
            inventory610 = inventory610.Replace(inventory610tb1.Text, inventory610tb2.Text);
            File.WriteAllText(path, inventory610);
            string inventory611 = File.ReadAllText(path);
            inventory611 = inventory611.Replace(inventory611tb1.Text, inventory611tb2.Text);
            File.WriteAllText(path, inventory611);
            string inventory612 = File.ReadAllText(path);
            inventory612 = inventory612.Replace(inventory612tb1.Text, inventory612tb2.Text);
            File.WriteAllText(path, inventory612);
            string inventory613 = File.ReadAllText(path);
            inventory613 = inventory613.Replace(inventory613tb1.Text, inventory613tb2.Text);
            File.WriteAllText(path, inventory613);
            string inventory614 = File.ReadAllText(path);
            inventory614 = inventory614.Replace(inventory614tb1.Text, inventory614tb2.Text);
            File.WriteAllText(path, inventory614);
            string inventory615 = File.ReadAllText(path);
            inventory615 = inventory615.Replace(inventory615tb1.Text, inventory615tb2.Text);
            File.WriteAllText(path, inventory615);
            string inventory616 = File.ReadAllText(path);
            inventory616 = inventory616.Replace(inventory616tb1.Text, inventory616tb2.Text);
            File.WriteAllText(path, inventory616);
            string inventory617 = File.ReadAllText(path);
            inventory617 = inventory617.Replace(inventory617tb1.Text, inventory617tb2.Text);
            File.WriteAllText(path, inventory617);
            string inventory618 = File.ReadAllText(path);
            inventory618 = inventory618.Replace(inventory618tb1.Text, inventory618tb2.Text);
            File.WriteAllText(path, inventory618);
            string inventory619 = File.ReadAllText(path);
            inventory619 = inventory619.Replace(inventory619tb1.Text, inventory619tb2.Text);
            File.WriteAllText(path, inventory619);
            string inventory620 = File.ReadAllText(path);
            inventory620 = inventory620.Replace(inventory620tb1.Text, inventory620tb2.Text);
            File.WriteAllText(path, inventory620);
            string inventory621 = File.ReadAllText(path);
            inventory621 = inventory621.Replace(inventory621tb1.Text, inventory621tb2.Text);
            File.WriteAllText(path, inventory621);
            string inventory622 = File.ReadAllText(path);
            inventory622 = inventory622.Replace(inventory622tb1.Text, inventory622tb2.Text);
            File.WriteAllText(path, inventory622);
            string inventory623 = File.ReadAllText(path);
            inventory623 = inventory623.Replace(inventory623tb1.Text, inventory623tb2.Text);
            File.WriteAllText(path, inventory623);
            string inventory624 = File.ReadAllText(path);
            inventory624 = inventory624.Replace(inventory624tb1.Text, inventory624tb2.Text);
            File.WriteAllText(path, inventory624);
            string inventory625 = File.ReadAllText(path);
            inventory625 = inventory625.Replace(inventory625tb1.Text, inventory625tb2.Text);
            File.WriteAllText(path, inventory625);
            string inventory626 = File.ReadAllText(path);
            inventory626 = inventory626.Replace(inventory626tb1.Text, inventory626tb2.Text);
            File.WriteAllText(path, inventory626);
            string inventory627 = File.ReadAllText(path);
            inventory627 = inventory627.Replace(inventory627tb1.Text, inventory627tb2.Text);
            File.WriteAllText(path, inventory627);
            string inventory628 = File.ReadAllText(path);
            inventory628 = inventory628.Replace(inventory628tb1.Text, inventory628tb2.Text);
            File.WriteAllText(path, inventory628);
            string inventory629 = File.ReadAllText(path);
            inventory629 = inventory629.Replace(inventory629tb1.Text, inventory629tb2.Text);
            File.WriteAllText(path, inventory629);
        }
    }
}