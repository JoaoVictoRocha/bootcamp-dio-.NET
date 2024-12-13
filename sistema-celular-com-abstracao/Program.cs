// See https://aka.ms/new-console-template for more information
using sistema_celular_com_abstracao.Models;

Nokia celular1 = new Nokia("99 99999-9999", "Nokia 3200", "26841698", 128);
Iphone celular2 = new Iphone("88 88888-8888", "Iphone 11", "138413487", 128);

celular1.InstalarAplicativo("Facebook");
celular2.InstalarAplicativo("Instagram");

