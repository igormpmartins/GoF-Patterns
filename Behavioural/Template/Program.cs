using Template;

FileWriter fw = new DESWriter("encrypted.txt");
fw.Append("The slow fat cat jumped over the table");


fw = new UnencryptWriter("unencrypted.txt");
fw.Append("The slow fat cat jumped over the table");

