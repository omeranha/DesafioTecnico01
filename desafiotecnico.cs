using System;
public class Ezio {
	static void Main() {
		int idade = 45;
		int anoDeNascimento = 1459;
		int membrosDaIrmandade = 150;
		int seguidoresLinkedIn = 2500;
		float cofreDaIrmandade = 75932.1546F;
		double bolsoDeEzio = 122.95;
		bool acessoCofre = false;
		bool foragido = true;
		char classificacaoAssassina = 'M';
		char saltosDeFe = '9';
		string nomeCompleto = "Ezio Auditore da Firenze";
		string descricaoLinkedIn = "Nós trabalhamos nas sombras para servir a luz, somo assassinos.";
		string localizacao = "Florença, Itália";
		
		Console.WriteLine("Qual opção você deseja acessar?");
		Console.WriteLine("1 - Acessar LinkedIn de {0} \n2 - Abrir cofre da irmandade", nomeCompleto);
		int entrada = int.Parse(Console.ReadLine());
		switch (entrada) {
			case 1:
				Console.WriteLine("\n{0}",nomeCompleto);
				Console.WriteLine(descricaoLinkedIn);
				Console.WriteLine("Nascido em {0}, atualmente com {1} anos. classificação {2} no credo dos Asassinos.", anoDeNascimento, idade, classificacaoAssassina, membrosDaIrmandade);
				Console.WriteLine("A irmandade é composta por aproximadamente {0} assassinos pelo mundo todo.", (membrosDaIrmandade + seguidoresLinkedIn));
				Console.WriteLine("{0} seguidores. {1}", seguidoresLinkedIn, localizacao);
				Console.WriteLine("{0} saltos de fé registrados.", saltosDeFe);
				if (foragido) {
				    Console.WriteLine("Ezio continua foragido e caçado pela Ordem dos Templários.");
				} else {
				    Console.WriteLine("Ezio fez um acordo com a policia local e se mantem seguindo a lei.");
				}
			break;

			case 2:
				if (!acessoCofre) {
					Console.WriteLine("Você não tem permissão de acesso ao cofre. Digite a senha (dica: procure no LinkedIn)");
					if (int.Parse(Console.ReadLine()) == anoDeNascimento) {
						acessoCofre = true;
						Console.WriteLine("Acesso permitido");
					}
				}

				Console.WriteLine("O cofre da irmandade tem {0:F2} Florins", cofreDaIrmandade);
				Console.WriteLine("No bolso de ezio há {0} Florins", bolsoDeEzio);
				break;
			}
	}
}