program potat;        //nom de votre programme
{
Interface générique simple à remplir seulement entre les begin...end pour faire une suite d'exercices
}
{
Programme :
Rôle :
Principe :
Auteur :
}

//uses                              //vos unités     (décommenter pour remplir)

//type                              //vos types

var                                 //vos variables   /!\Ne pas toucher à celles déjà présentes
  numeroEx,sousNum:Integer;


Begin 
writeln('Tapez le numero de votre exercice que vous voulez executer(de 1 a 3):');
writeln('Ou tapez 0 si vous voulez sortir'); 
readln(numeroEx);

while numeroEx <> 0 do
  begin
  case numeroEx of
       1:
         begin
         //Inserez le code de l'ex 1
         end;                       //end de fin de numEx 1
       2:
         begin
         //Inserez le code de l'ex 2
         end;                       //end de fin de numEx 2
       3:
         begin
         Writeln('Quel sous-numero ?');
         readln(sousNum);
         case sousNum of
         3:
           begin
           //Inserez le code de l'ex 1.3
           end;                  //end de fin de sousNum 3

         3:
           begin
           //Inserez le code de l'ex 2.3
           end;                  //end de fin de sousNum 3

         3:
           begin
           //Inserez le code de l'ex 3.3
           end;                  //end de fin de sousNum 3

         end;                       //end de fin de Case sousNum of

         end;                       //end de fin de numEx 3
else
  begin
  Writeln('Numero incorrect');
  end;                              //end de fin de else

end;                                //end de fin de Case numeroEx of 

writeln('Tapez le numero de votre exercice que vous voulez executer (de 1 a 3):');
writeln('Ou tapez 0 si vous voulez sortir');
readln(numeroEx);

end;                               //end de fin de while numeroEx <> 0

end.                               //end de fin de programme                       ~~Auteur du pré code généré : Ronan PEYREL, promo 2020
