using System;
using System.IO;

namespace Projet_EZPascal_Csharp
{
    internal class Writing
    {

        private string name;
        private string path;

        public Writing(string name, string path)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.path = path ?? throw new ArgumentNullException(nameof(path));
        }

        public void entete(int nbEx)   //file heading (headings comments, name, "uses", var etc...)
        { //var fichier:text; nom:string;nbEx:Integer

            StreamWriter sw = new StreamWriter(path, true);    //open the file
            
            //Write the heading of the file
            sw.WriteLine("program "+name+";        //nom de votre programme");
            sw.WriteLine("{");
            sw.WriteLine("Interface générique simple à remplir seulement entre les begin...end pour faire une suite d'exercices");
            sw.WriteLine("}");
            sw.WriteLine("{");
            sw.WriteLine("Programme :");
            sw.WriteLine("Rôle :");
            sw.WriteLine("Principe :");
            sw.WriteLine("Auteur :");
            sw.WriteLine("}");
            sw.WriteLine("");
            sw.WriteLine("//uses                              //vos unités     (décommenter pour remplir)");
            sw.WriteLine("");
            sw.WriteLine("//type                              //vos types");
            sw.WriteLine("");
            sw.WriteLine("var                                 //vos variables   /!\\Ne pas toucher à celles déjà présentes");
            sw.WriteLine("  numeroEx,sousNum:Integer;");
            sw.WriteLine("");
            sw.WriteLine("");
            sw.WriteLine("Begin ");
            sw.WriteLine("writeln('Tapez le numero de votre exercice que vous voulez executer(de 1 a "+nbEx+ "):');");
            sw.WriteLine("writeln('Ou tapez 0 si vous voulez sortir'); ");
            sw.WriteLine("readln(numeroEx);");
            sw.WriteLine("");
            sw.WriteLine("while numeroEx <> 0 do");
            sw.WriteLine("  begin");
            sw.WriteLine("  case numeroEx of");

            sw.Close();         //close the file
        }                       

        public void numex_debut(int j)              //begginning of exercises : the "begin", its number
        {//(j:integer; var fichier:text;nom:string)
            StreamWriter sw = new StreamWriter(path, true);   //open the file
            
            sw.WriteLine("       "+j+":");
            sw.WriteLine("         begin");
            sw.Close();                                 //close the file
        }

        public void entete_SN()                     //heading of sub-exs : thr "case of..."
        {//(var fichier:text; nom:string)
            StreamWriter sw = new StreamWriter(path, true);   //open the file

            sw.WriteLine("         Writeln('Quel sous-numero ?');");
            sw.WriteLine("         readln(sousNum);");
            sw.WriteLine("         case sousNum of");

            sw.Close();                                 //close the file
        }

        public void SN(int j, int k)                       //the sub exs their "begin", numbers, and "end"
        {//(k:integer; var fichier:text;nom:string)
            StreamWriter sw = new StreamWriter(path, true);   //open the file

            sw.WriteLine("         "+k+":");
            sw.WriteLine("           begin");
            sw.WriteLine("           //Inserez ici le code de l'ex "+j+"."+k);
            sw.WriteLine("           end;                  //end de fin de sousNum "+k);
            sw.WriteLine("");
            
            sw.Close();                                 //close the file
        }

        public void SN_fin()                        //end of sub ex's "case of"
        {//(var fichier:text; nom:string)
            StreamWriter sw = new StreamWriter(path, true);   //open the file

            sw.WriteLine("         end;                       //end de fin de Case sousNum of");

            sw.Close();                                 //close the file
        }

        public void numex_fin(int j, int k)                //end of exerices "case of"
        {//(j:integer; var fichier:text;nom:string)
            StreamWriter sw = new StreamWriter(path, true);   //open the file

            if (k == 0)
            {
                sw.WriteLine("         //Inserez ici le code de l'ex " + j);
            }
            else
            {
                sw.WriteLine("");
            }
            sw.WriteLine("         end;                       //end de fin de numEx "+j);

            sw.Close();                                 //close the file
        }

        public void FIN(int nbEx)                   //file footer : option "incorrect number", asking for new number and end of loops
        {//(var fichier:text; nom:string;nbEx:Integer)
            StreamWriter sw = new StreamWriter(path, true);   //open the file

            sw.WriteLine("else");
            sw.WriteLine("  begin");
            sw.WriteLine("  Writeln('Numero incorrect');");
            sw.WriteLine("  end;                              //end de fin de else");
            sw.WriteLine("");
            sw.WriteLine("end;                                //end de fin de Case numeroEx of ");
            sw.WriteLine("");
            sw.WriteLine("writeln('Tapez le numero de votre exercice que vous voulez executer (de 1 a "+nbEx+"):');");
            sw.WriteLine("writeln('Ou tapez 0 si vous voulez sortir');");
            sw.WriteLine("readln(numeroEx);");
            sw.WriteLine("");
            sw.WriteLine("end;                               //end de fin de while numeroEx <> 0");
            sw.WriteLine("");
            sw.WriteLine("end.                               //end de fin de programme                       ~~Auteur du pré code généré : Ronan PEYREL, promo 2020");

            sw.Close();                                 //close the file
        }

    }
}