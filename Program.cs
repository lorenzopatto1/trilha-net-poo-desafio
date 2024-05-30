using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("1", "tijolo", "197538", "4GB");
Iphone iphone = new Iphone("2", "14", "321597", "128GB");

nokia.Ligar();
iphone.Ligar();

nokia.ReceberLigacao();
iphone.ReceberLigacao();

nokia.InstalarAplicativo("Whatsapp");
iphone.InstalarAplicativo("Whatsapp");
