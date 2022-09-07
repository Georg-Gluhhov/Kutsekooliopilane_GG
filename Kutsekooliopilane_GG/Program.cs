using Kutsekooliopilane_GG;

Tootaja Tootaja = new Tootaja("Test","Test",1600 ,"Oleg", 1993, Tootaja.sugu.mees);
Tootaja.print_Info();
Tootaja.calculateAge();
Tootaja.calculateIncome();
Tootaja.changeName();
Tootaja.print_Info();

Opilane Opilane = new Opilane("test","test","test","Matvei",2004, Opilane.sugu.mees);
Opilane.print_Info();
Opilane.calculateAge();
Opilane.calculateIncome();
Opilane.changeName();
Opilane.print_Info();
Opilane.ChangeBirthdate();

Kutsekooliopilane Kutsekooliopilane = new Kutsekooliopilane("test","test",3,120,"Matvei",1999, Opilane.sugu.mees);
Opilane.print_Info();
Opilane.calculateAge();
Opilane.calculateIncome();
Opilane.changeName();
Opilane.print_Info();
