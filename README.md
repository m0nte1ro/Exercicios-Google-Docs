# Exercicios-Google-Docs
Exercicios encontrados no Google Docs do Professor.

Programação Baseada em Objectos


1.Retângulo

Crie uma classe Retangulo com os atributos largura e comprimento (inteiros, com o valor 1 por omissão, com o valor máximo de 20). Crie dois construtores, um vazio e um que aceite como parâmetros os dois valores. Crie métodos que retornem o perímetro e a área. Crie um método Quadrado() que retorne um valor booleano indicando se se trata de um quadrado. Crie um método toString() indicando as dimensões do retângulo numa string. 

Crie as propriedades de acordo com as restrições referidas. 

Teste a classe e todos os métodos.  




2.Paralelepipedo

Crie uma classe Paralelepípedo que permita descrever este objecto através das suas 3 dimensões (altura,largura,comprimento - valores inteiros). Deverá conter os seguintes construtores:

Construtor sem argumentos (colocando os valores das variáveis a 0).
Construtor apenas com um argumento onde todas as variáveis são colocadas no mesmo valor.
Construtor onde as 3 variáveis são passadas como argumento. 
Propriedades para as variáveis. Em qualquer caso, se um dos valores for negativo, deverá ser colocado a zero. 
Método para o volume do paralelipipedo ( v= a.l.c), 
Método para o cálculo área total do objeto (área = 2.a.l + 2.a.c + 2.l.c),
Método override ToString() (p. Ex. “a=4;l=3;c=2”). 
Deverá ter um método público IsACube() que retornará um valor booleano indicando se o objeto representa um cubo (todos as variáveis têm o mesmo valor).
Método público Is3D() que retorne true se todas as variáveis forem diferentes de zero (não nulas) e false em caso contrário. 

Crie um programa para testar a classe, todos os métodos e construtores a partir de valores aleatórios.




3.Aluno ISMAI

Crie uma classe para descrever um aluno do ISMAI com nome, número, ano, curso. Crie apenas um único construtor onde todas as variáveis são passadas como argumentos. Crie:

Respetivas Propriedades.
Um override de ToString() - “João Manuel Silva 12345, 1º ano DJD”
Um método bool InscritoAntes() que receba um Objecto do tipo Aluno como argumento, para comparar alunos pelo número de inscrição [exemplo para testar.
Método PrimeiroUltimoNome() para retornar apenas o primeiro e último nome do aluno. 
Testar Classe.





4.Disciplina


Crie ao seu critério uma classe Disciplina para descrever uma disciplina do ISMAI: 

variáveis privadas nome da disciplina, carga horária semanal, semestral ou anual (bool), nome do docente, nome do curso, número de alunos inscritos. 
Propriedades. Restrições: carga horária não pode ser negativa nem maior do que 8. O número de alunos inscritos não pode ser negativo. 
Os cursos só podem ser DJD, ARTES e TCM. Por omissão terá o valor “não definido”. 
Criar um construtor vazio onde todas as variáveis são colocadas nos valores por omissão: strings vazias e inteiros a zero.
Crie um construtor que aceite todas as variáveis de classe.
Faça o override do método ToString() que indique o nome da disciplina, docente e nome do curso.
Método que calcule a carga horária global da disciplina (considere 15 semanas por semestre)
Testar com um programa. 




5.Racional

Crie uma classe Racional para descrever fracções através do numerador e denominador. 

Crie um construtor para instanciar os objetos da classe, garantindo que os valores são aceitáveis e um construtor nulo que coloque os valores a 1. 
Crie as propriedades. 
Crie um método override ToString() para apresentar a fracção na sua forma reduzida (ou seja 2/4 é apresentado como ½ e 4/12 é representado como 1/3). 
Crie métodos para adicionar, subtrair, multiplicar e dividir frações. 
Crie um método para apresentar a fracção como um número em vírgula flutuante. 
Teste a classe em que o denominador e o numerador são introduzidos pelo utilizador

 
6.Notebook

A classe Notebook deverá ter variáveis para a marca (string. Exemplo: “HP”), processador (string, exemplo “Ryzen”). Deverá utilizar variáveis para descrever o cpu, memórias, gráfica e disco.

Crie um construtor vazio onde as strings são inicializadas vazias e o valor booleano a true.
Crie um construtor que aceite como argumento os valores das variáveis. 
As strings deverão ter no máximo 2 palavras (senão serão truncadas a duas palavras). 
Crie as propriedades para as variáveis tendo em atenção as restrições acima referidas.
Faça o override do método ToString() onde é indicado a marca, modelo e velocidade de relógio. Exemplo: “HP, Ryzen, LCD“. Note que o tipo de monitor é uma string. No caso de algumas das strings estar vazia ou de o valor da velocidade ser nulo, o método deverá retornar a string “não definido”.
Crie métodos ComparaMemoria(), ComparaProcessador() que recebam um objecto Computador como argumento e retorne um valor inteiro: (zero se o Computador passado como argumento for igual, 1 se for superior e -1 se for inferior).
Teste os métodos ComparaComputador e ToString com um programa. Introduza os valores pelo utilizador (deverá perguntar o tipo de monitor) e instancie 3 objectos da classe Computador, incluindo um objecto com valores incorrectos. 

 
7.Matriz
 
Crie uma classe Matriz para descrever uma matriz 10X10 de valores inteiros num determinado intervalo.

A classe deverá possuir como variável de classe a dita matriz 10X10 e dois inteiros que indicam os limites entre os quais os valores deverão se situar (num intervalo fechado). 
Deverá possuir os seguintes métodos:

Construtor vazio. Neste caso os limites serão 0 (zero) e 9 (nove) e a matriz será preenchida inicialmente por zeros. Nota: Os vectores e matrizes são objectos.

Construtor onde são passados como argumentos dois valores inteiros (limsup e liminf) correspondendo aos limites. Neste caso a matriz será também preenchida inicialmente por zeros. Se o limite superior for inferior ao limite inferior estas variáveis deverão ser trocadas. 

Construtor onde são passados 3 valores inteiros. O primeiro representa o valor inteiro com que a matriz vai ser totalmente preenchida. Os outros dois valores representam os limites. Deverá ser verificada a condição referida no ponto anterior em relação aos limites. Se o valor com que a matriz deverá ser preenchida estiver fora dos limites, a matriz deverá ser preenchida com o valor correspondendo ao limite inferior.

Construtor onde são passados 2 valores inteiros (os limites) e um valor booleano. Se o valor booleano for true a matriz deverá ser preenchida por valores aleatórios entre os limites referidos. Em caso contrário a matriz deverá ser preenchida com o limite inferior. 

Método int SomatorioMatriz() que retorne o valor da soma de todos os elementos da matriz.

Método ToString() que retorne uma string indicando o os limites superior e inferior e a média  (inteiro) da matriz. Ex. “Limite Superior: 10 Limite Inferior: 5 Média: 7”

Teste a classe. 
 

8.Cliente


Crie uma classe Cliente para descrever clientes da  Vodafone  e que conterá variáveis para guardar o nome próprio, apelido, número de contribuinte, telefone e crédito (inteiro, em cêntimos de €).  Escolha o tipo de variáveis a utilizar com algum cuidado. 

É importante considerar o seguinte na criação dos Construtores e das Propriedades:
O número de contribuinte tem obrigatoriamente 9 algarismos.
O número de telefone tem 9 algarismos e deve começar pelo indicativo 91.
O crédito poderá ser positivo ou negativo. 
Crie um construtor onde são passados apenas o nome, apelido e número de contribuinte do cliente.

  O número de telefone é colocado em 000000000 e o crédito a zero.
Crie um construtor onde são passados como argumentos todas as variáveis de classe. 
Método VariaCredito() que receba um valor inteiro em cêntimos de € e adicione este valor ao valor do crédito (poderá ser um valor negativo).
Método CreditoPositivo() que retorne um valor booleano se o crédito for um valor positivo.
Método ToString() que retorne o nome do cliente e o número de telefone.
Método CreditoTelefone() que retorne uma string indicando o número de telefone e o crédito em € (não em cêntimos de €). Exº  “921435337 crédito: 1,25€” 
Teste a classe. Instancie dois objectos com os dois construtores. Teste todos os métodos criados com pelo menos um caso.
 
Crie uma classe chamada QuatroPalavras

A classe deverá possuir como variável de classe um vector de quatro strings, cada uma representando uma palavra. 
Deverá possuir os seguintes métodos:
Construtor vazio. Neste caso as palavras serão inicializadas com strings vazias “”.
Construtor onde é passado um argumento (uma string). As palavras serão inicializadas todas com esta string. Se a string contiver espaços, estes devem ser eliminados. Além disso as palavras deverão ser convertidas para minúsculas.
Construtor onde são passados 4 strings, sendo cada uma atribuída a uma das palavras, atendendo às exigências apresentadas na alínea anterior (eliminar espaços e converter para minúsculas.
Método void SetPalavra(string pal, int numero) que atribui a string pal à palavra na posição indicada pelo número inteiro. Se a posição estiver fora dos limites não será efectuada qualquer atribuição.
Método string GetPalavra(int numero) que retorna a palavra na posição indicada. Se a posição estiver fora dos limites é retornada a string vazia “”.
Método bool TodasIguais() que retornará um valor true se as palavras forem todas iguais.
Método bool TodasDiferentes() que retornará um valor true se as palavras forem todas diferentes. 
Método bool HaDuasIguais() que retornará um valor true houver pelo menos duas strings iguais. 
Método ToString() que retorne uma string com as 4 palavras concatenadas separadas por espaços.
Teste a classe.  

 
Automóvel
Crie uma classe Automovel para descrever um veículo automóvel. A classe Automovel deverá ter variáveis para a marca (string. Exemplo: “Ferrari”) e modelo (string. Exemplo “350GTO”). Deverá ter uma variável para a matrícula (string), uma para a cilindrada (inteiro) e uma variável para a cor (string). Deverá ainda ter uma variável para a data de matrícula. Esta data deverá ser um objecto de uma classe DateTime. 
Crie um construtor vazio onde as strings são inicializadas vazias e o valor inteiro a zero. A matrícula é inicializada a “AA-00-00”. A data será o dia 1 de Janeiro de 1900. 
Crie um construtor que aceite como argumento os valores das variáveis. A matrícula deverá corresponder a uma matrícula portuguesa senão será colocada no valor por omissão. A cilindrada deverá ser um valor positivo, senão será colocada com o valor zero.
Crie as propriedades para as variáveis tendo em atenção as restrições acima referidas.
Faça o override do método ToString() onde é indicado a marca, modelo e matrícula. Exemplo: “Ferrari 350GTO, XX-78-23”
No caso de algumas das strings estar vazia ou de o valor da cilindrada ser nulo, o método deverá retornar a string “não definido”.
Crie um método ComparaAutomovel() que receba um objecto Automovel como argumento e retorne um valor booleano indicando se a Marca, modelo e matrícula são iguais. No caso de uma ou mais destas variáveis serem diferentes, o método retornará false.
Crie um método ComparaData() que receba um objecto DateTime como argumento e retorne um valor booleano indicando se a Data do automóvel é anterior (true) ou posterior (false) à Data passada como argumento. 
Teste os métodos ComparaAutomovel(), ComparaData e ToString() com um programa. Não é necessária a introdução de valores pelo utilizador. Instancie 3 objectos da classe Automovel, incluindo um objecto com valores incorrectos (cilindrada negativa). 
 
Paragem
Crie uma classe chamada Paragem para descrever uma determinada paragem de autocarros de carreira. A classe deverá ter variáveis para descrever o código da paragem (um inteiro entre 1 e 10000), o nome da paragem e o Concelho onde se encontra (por exemplo “Maia”). 
 Deverá ter apenas um construtor onde são passadas todas as variáveis como argumentos. O construtor deverá garantir que o código da paragem está no intervalo referido (senão é colocado a zero), e que o nome do concelho está no conjunto [“Maia”, “Porto”, “Valongo”, “Gondomar”, “Gaia”, “Matosinhos”], ignorando maiúsculas e minúsculas. Se o nome do concelho não estiver com a maiúscula inicial e as outras letras minúsculas, o construtor deverá corrigir o nome. No caso de o nome não estar no intervalo referido, deverá ser colocada uma string vazia. 
 Deverá ter o método ToString() (“1234: Alto da Areosa – Porto”). No caso de qualquer dos dados ser indeterminado, o método retornará “Não definido”. 
Propriedades, verificando as restrições. 
Crie uma classe designada por Carreira para descrever uma determinada carreira de autocarros de uma sociedade de transportes colectivos.
A classe Carreira deverá ter variáveis para o número da carreira (entre 1 e 99). Deverá ter ainda uma variável booleana indicando se tem serviço nocturno e uma variável booleana indicando se tem serviço ao fim de semana. Deverá ainda ter um vector de Paragem indicando as paragens da carreira. O elemento zero do vector corresponde à paragem inicial e o último elemento à paragem término. 
Deverá ter um construtor que aceite todas as variáveis como argumento incluindo um vector de Paragem. Deverá garantir que o número de carreira está no intervalo referido (senão é colocado a zero). 
Propriedades para as variáveis, incluindo o vector de Paragem. Deverá verificar as restrições acima indicadas. 
O método ToString() indicará o número da carreira e as paragens inicial e final (“29 Travagem – Bolhão”) No caso de o vector de paragens ter menos de 2 elementos ou no caso de o número de carreira ser zero, deverá surgir “Não definido”. 
Crie um método ComparaCarreira() que receba uma Carreira como argumento e retorne um valor booleano indicando se a carreira que é passada como argumento tem exactamente o mesmo percurso da carreira correspondente ao objecto em causa. 
Crie um método ComparaParagens() que receba uma Carreira como argumento e retorne o número de Paragens que são comuns a ambas as carreiras. Deverá comparar pelo código da paragem. 
 
Equipa
12) Crie uma classe Equipa  para descrever uma equipa de futebol participante no Mundial de Futebol.
A classe Equipa deverá ter variáveis descrever o país (string), Ranking da FIFA (inteiro positivo), data de inscrição (DateTime). 
(2) Crie as propriedades para as variáveis. O nome do país participante. O Ranking da FIFA deverá  ser um valor inteiro positivo menor do que 100, senão será colocado a zero. A data de inscrição deverá ser igual ou anterior à data presente, senão será colocada no dia presente.. 
(1) Crie um construtor que receba todas as variáveis como argumentos. 
(1) Faça o override do método ToString() que deverá indicar o país (se diferente de “Não Definido” e ranking da FIFA (se diferente de zero).
(1) Crie um método ComparaRankings() que receba um objecto do tipo Equipa como argumento e retorne um valor inteiro indicando o valor absoluto da diferença de rankings entre as equipas.  

Crie uma classe chamada Grupo que represente um grupo da fase de qualificação do Mundial de Futebol. O Grupo deverá ter variáveis para descrever a designação (uma letra de A a H) e as equipas participantes (um vector de 4 Equipas).
Crie as propriedades. A letra deverá só poderá ser uma das seguintes: A, B, C, D, E, F, G, H. 
Crie um construtor que receba o vector de equipas e a designação do grupo como argumentos. 
O método ToString deverá escrever a designação do grupo e o nome das 4 equipas. Exemplo: “Grupo D: Portugal, México, Angola, Irão”).
Crie um método EquipasRepetidas que retorne um valor booleano true se por algum motivo houver duas equipas com o mesmo nome no grupo.

Teste as classes com um programa. Deverá instanciar apenas 4 objectos do tipo Equipa (com valores à sua escolha) e colocá-los num vector. Depois deverá instanciar um Grupo com estas equipas. Teste o método ToString do Grupo. 
Percorra o Grupo e verifique se não há duas equipas com o mesmo ranking. 

 
13) Crie uma classe Jogador para descrever um jogador de futebol participante no Mundial de Futebol.
A classe Jogador deverá ter variáveis descrever o nome (string), número da camisola (inteiro), data de nascimento (DateTime) e golos marcados no torneio (inteiro).
. 
Crie as propriedades para as variáveis. O nome deverá ter no máximo 20 caracteres. Em caso contrário será truncado nos 20 caracteres. Todos os espaços iniciais ou finais do nome deverá ser eliminados. O número da camisola deverá estar entre 1 e 23. Em qualquer outro caso, o número será colocado a 0 (zero). O número de golos deverá ser igual ou superior a zero. Em qualquer outro caso deverá ser colocado no valor zero. 
Crie um construtor que receba todas as variáveis como argumentos excepto o número de golos, que deverá ser colocado a zero. 
Faça o override do método ToString() que deverá indicar o nome, número da camisola (se diferente de zero) e a idade (calcule a partir da data actual).
Crie um método MarcouGolos(int golos) que receba um valor inteiro como argumento (representando o número de golos marcado num determinado jogo) e acrescente este valor ao número de golos marcado pelo jogador. Se o argumento for negativo deverá ignorar o método.
Crie um método ComparaJogador() que receba um objecto do tipo Jogador como argumento e retorne um booleano true indicando se o Jogador passado como argumento marcou mais golos do que o objecto sobre o qual é executado o método. 

Crie uma classe chamada Equipa que represente uma equipa participante no Mundial de Futebol. A Equipa deverá ter variáveis para descrever o país (string), o nome do treinador (string) e um vector de objectos Jogador. 
Crie as propriedades. As únicas restrições são o tamanho das strings (limitadas a 20 caracteres).
Crie um construtor que receba duas strings (nome do país e nome do treinador) e um vector de Jogador.
O método ToString() deverá apresentar apenas o nome do país e o nome do treinador. 
Crie um método MediaIdades() que retorne a média de idades da equipa. 
Crie um método Verifica() para verificar se não há dois jogadores com o mesmo número de camisola. O método deverá retornar o valor true se não houver dois jogadores com o mesmo número de camisola. 

Teste as classes com um programa. Deverá instanciar apenas 5 objectos do tipo Jogador (com valores à sua escolha) e colocá-los num vector. Depois deverá instanciar uma Equipa. 
Deverá testar o método ToString() de Equipa e percorrer o vector de Jogador apresentando o método ToString() de Jogador.
Deverá testar o método MediaIdades() de Equipa e o método Verfica() (deverá indicar se todos os jogadores têm números de camisola diferentes).

Programa
Crie uma classe designada como “Programa” para descrever um programa de televisão. A classe deverá ter variáveis para representar:
1. O nome do programa de televisão
2. O canal em que é exibido
3. A duração do programa em minutos.
 
Restrições: 
1. O nome não poderá ter mais de 20 caracteres senão será truncado nos 20 caracteres. Deverá ser iniciado por uma letra maiúscula ou algarismo. No caso de o primeiro carácter ser minúsculo deverá convertê-lo para maiúsculo. 
2. O canal onde é exibido deverá ser constituído apenas por uma palavra. No caso de ser enviado como argumento mais de uma palavra deverá apenas considerar a primeira palavra e eliminar quaisquer espaços no nome. 
3. A duração terá de ser um valor inteiro positivo superior a 10 e inferior a 180. Se o valor não obedecer a esta condição será colocado no valor zero. 
Deverá ter um construtor que receba as 3 variáveis de classe como argumento e as coloque em valores consistentes. Deverá ter as propriedades para todas as variáveis. 
O método ToString deverá apresentar o nome do programa seguido do canal em que é exibido, seguido da duração (se tiver um valor válido, ou seja, diferente de zero).
Deverá ter um Método CurtaDuracao que retornará um valor booleano que será true se a duração for igual ou inferior a 1 hora. 
Crie um método que retorne uma string com as iniciais (necessariamente maiúsculas) do nome do programa. Exemplo:
Entrada: “Felicidade a Granel” Saída: “FAG”. 
 
Teste a classe e os métodos com valores introduzidos através de caixas de texto. Crie um vector com 6 objectos da classe Programa e ordene-os de acordo com a duração, canal e por ordem alfabética do nome (a partir de botões)




Crie uma classe designada por  Filme, representando um determinado filme 
A classe deverá possuir como variáveis de classe uma string (para o nome do filme), um valor inteiro representando o ano de produção e um valor inteiro representando a duração do filme em minutos.
A classe Filme deverá possuir os seguintes métodos:
Construtor (e propriedades) que aceite todas as variáveis de classe como argumentos. Deverá garantir que a duração do filme tem um valor positivo (em caso contrário deverá colocá-lo a zero). Deverá ainda garantir que o ano de produção se situa entre 1980 e 2005 inclusivé (em caso contrário colocará este valor a zero). 
Método ToString() indicando o título, duração e ano de produção. Exemplo: “A vida das Escovas, 50 min, 1989”. 
Método curtaDuracao() que retorne um valor booleano true se a duração do filme for inferior a 100 minutos. 
Crie uma subclasse da classe Filme, designada como Comedia. Deverá acrescentar as seguintes variáveis de classe: Nome do realizador (string) e um vector de 5 strings que conterá o nome dos actores ou actrizes principais. 
Crie um construtor para esta subclasse, onde são passadas todas as variáveis de classe, incluindo os nomes do realizador e dos actores principais. Eventualmente poderão ser passadas strings vazias se não existirem 5 actores principais. O construtor deverá garantir que são preenchidas as primeiras posições do vector de strings referido, ou seja, se houver strings vazias, estas deverão estar nas últimas posições do vector. 
Esta subclasse deverá fazer o Override do método ToString() (aproveitando o método da classe Filme, de modo a indicar o nome do realizador. “A vida das Escovas, 50 min, 1989, realizado por Estevão Espilbergue”. 
Teste as classes Filme e Comedia com uma aplicação. 


Crie uma classe Recluso contendo duas variáveis de classe: nome (string) e numero (inteiro 4 dígitos).

Para a classe Recluso crie um construtor que aceite como argumentos duas variáveis que serão atribuídas às variáveis de classe. O construtor apenas deverá copiar para o nome o primeiro e último nome do argumento (Se o nome passado como argumento for “José Maria Passos Silva” a variável de classe nome será “José Silva”. Deverá ainda copiar apenas os últimos 4 algarismos do número, no caso do inteiro ter mais de 4 dígitos (ex. Se o argumento for o número 23456, a variável de classe número tomará o valor 3456).
(Crie um método ToString() que retorne o nome do recluso e o número ex. “José Maria, 3456”. Se o número for inferior a 1000, o método deverá colocar zeros à esquerda ex. “Manuel Sá 0345”. Nota: Não é necessário criar mais métodos para esta classe.
Crie uma subclasse de Recluso, chamada Preventivo, que acrescenta uma variável inteira representando o ano de chegada do recluso.
Crie um construtor para a classe Preventivo que aceite como argumentos todas as variáveis de classe e utilize o construtor da superclasse. Deverá verificar que o ano se situa entre 1990 e 2002. Em caso contrário colocará o valor zero nesta variável.
Crie um método ToString() que utilize o método ToString() da superclasse e retorne uma string do género “José Maria, 3456/2002” (Nome, número, ano de chegada)
Teste esta hierarquia com uma aplicação, instanciando um objecto da classe Preventivo e chamando o método ToString().


Uma editora “H. Xadinho Lda” (de livros e software) pretende modelizar os seus artigos num sistema orientado a objectos. 

Crie uma classe de topo abstract chamada Artigo, para descrever um artigo vendido pela editora. Esta classe deverá conter os seguintes métodos e variáveis:

Variáveis:

Título do Artigo
Preço (double, em euros)
Nomes dos autores ou produção (no máximo 5 autores)

Métodos

Método ToString(), indicando todas as variáveis. 

“Programação em JAVA; João Silva, Pedro Silva; 45.5 €”. 

Não esquecer que deverá apresentar o nome de todos os autores separado por vírgulas!

Crie uma classe Livro como subclasse da classe Artigo. A classe deverá conter ainda variáveis para descrever o ISBN do livro (10 algarismos) e o número de páginas. Deverá por fim ter uma variável booleana indicando se é ou não um livro de capa dura (Hardcover). Crie os construtores e métodos que achar necessários, incluindo um método ToString que descreva todas as variáveis da classe, do tipo:

“Programação em JAVA; João Silva, Pedro Silva; 45.5 €; ISBN: 6930685493; 300 páginas; capa dura, Ed. H. Xadinho Lda”. 

(Em caso de não ser de capa dura deverá indicar “capa de papel”)

Deverá ter um método GetCapa() que retorne o valor true se o livro for de capa dura.

Crie uma classe Software como subclasse da classe Artigo. A classe deverá conter ainda variáveis para descrever o SO do software (exemplo: “Windows”) e o tipo de software (exemplo “Jogo” ou “didáctico”. Crie os construtores e métodos que achar necessários, incluindo um método ToString (2 valores) que descreva todas as variáveis da classe, do tipo:

“Lethal Battle, XPTO productions, 13.5 €, Windows, Jogo”

Teste as classes com uma aplicação onde os dados são lidos de uma base de dados.


Casamento
Crie uma classe Participante para representar um participante de um casamento. O participante será abstract e terá apenas o primeiro e último nome como variáveis de classe. 
Crie uma subclasse de Participante, a classe Noivo (bool sexo, int idade) que represente o noivo ou noiva num casamento. Sexo: true - feminino false - Masculino. Apenas são necessários os seguintes métodos: Construtor que receba todos os argumentos. Deverá verificar se a idade é superior a 16. Em caso contrário deverá colocar a idade a 16. 
Propriedades.
Método ToString “João Pedro Silva, 30 anos, Sexo Masculino”

Crie uma subclasse de Participante, Padre (string paróquia) 
Construtor que receba todos os argumentos. Não são necessárias verificações.
Método ToString “Armindo Ferreira Costa, pároco de Alfarrobas de Baixo”

Crie uma subclasse de Participante, Convidado que terá apenas mais duas variáveis booleanas (tipo: true – normal false – testemunha) (convite: true – lado do noivo false – lado da noiva)

Crie uma classe Casamento que inclua dois objectos da classe Noivo, um da classe DateTime, um vector de Convidados e um da classe Padre. Deverá ainda ter um valor inteiro para o custo. 

e) Crie um construtor para a classe Casamento que receba todos os argumentos, incluindo todos os objectos e o vector de convidados.

f) Método que retorne a diferença de idades dos noivos.

g) Propriedades; 

h) Método ToString:

“Casamento de João e Maria, realizado no dia 10 de Maio do ano da graça de 2006, pelo padre Armindo Ferreira Costa, na igreja de Alfarrobas de Baixo”

(repare que apenas são apresentados os primeiros nomes dos noivos!)

i) Teste as classes com uma aplicação. Instancie dois objectos da classe Noivo (de preferência de sexos diferentes) - os noivos deverão ter pelo menos 2 nomes. Instancie um objecto da classe Padre, um da classe DateTime, um vector pequeno de Convidados e finalmente um objecto da classe Casamento. Apresente os resultados dos métodos da classe Casamento.

9. Crie uma hierarquia de classes para um torneio de ténis. 

a) A classe de topo, declarada abstract deverá ser designada por Elemento (string nome, string nacionalidade, int idade) que represente um elemento geral participante no torneio. Apenas são necessários os seguintes métodos: 
Método ToString “João Pedro Silva, 30 anos, Portugal”
A superclasse elemento terá 2 subclasses: Jogador e Arbitro. 
b) A classe Jogador terá os seguintes métodos e variáveis:
Variável booleana para representar o sexo (True > Masculino, False > Feminino)
Valor inteiro para representar o ranking ATP.
Construtor que aceite todas as variáveis de classe. Deverá verificar que o ranking é um número positivo. Em caso contrário deverá colocá-lo a zero. 
Método ToString que deverá retornar a seguinte string, utilizando o método da superclasse “Andre Agassi, 30 anos, EUA, 4º ATP”. Se o ranking for zero não será colocado!
Método SexoJogador que retornará uma string “Masculino” ou “Feminino” conforme o caso.
c) A subclasse Arbitro deverá ter os seguintes métodos e variáveis.
Variável para representar a classe do arbitro, inteiro que apenas pode tomar os valores 1, 2 e 3. 
Construtor que aceite todas as variáveis de classe. Deverá verificar que a classe é um número dentro dos valores indicados. Em caso contrário deverá colocá-lo a zero. 
Método ToString que deverá retornar a seguinte string, utilizando o método da superclasse “João Pedro Silva, 30 anos, Portugal, 1ª classe”. Se a classe for zero não será colocada!
d) Crie uma classe Jogo, que terá as seguintes variáveis de classe:
2 variáveis da classe Jogador
1 variável da classe Arbitro.
1 inteiro representando o número da eliminatória (0 se for a final)
1 string indicando o nome do torneio.
A classe Jogo deverá ter os seguintes métodos:
Construtor que aceite todas as variáveis de classe. Os objectos são passados como argumentos, por isso deverão ser instanciados anteriormente!
GetNomeFavorito que retornará o nome do favorito de acordo com o ranking.
Método ToString que retornará uma string do género “Andre Agassi v. Tim Henman”.
e) Teste as classes com uma aplicação. Não é necessário os valores serem introduzidos pelo utilizador! Instancie dois objectos da classe Jogador, um da classe Arbitro e um da classe Jogo. Teste os métodos da classe Jogo. 

10 Crie um conjunto de classes para um jogo de basquetebol (composição)

a) Crie uma classe designada como Jogador (string nome, string nacionalidade, int idade, int numCamisola) para representar um jogador de uma equipa de basquetebol. Crie um construtor e os seguintes métodos:
Método ToString(): “Perneta, Brasil, número 10”

b) Crie uma classe Arbitro (string nome, int numInscricao). Crie os construtores e métodos que achar necessários, incluindo um método ToString.
Propriedades
Método ToString(): “João Galifão, número de inscrição: 1230”

c) Crie uma classe Equipa que represente uma equipa de basquetebol, com variáveis para representar o nome da equipa o número de inscrição na Liga (inteiro de 4 dígitos), e um vector de 5 elementos da classe Jogador para representar os jogadores. Crie um construtor onde sejam passados todos as variáveis representando os jogadores, já previamente instanciadas (ou seja os objectos são passados para o construtor). Crie propriedades. O método ToString deverá apresentar os nomes de todos os jogadores.

d) Use a classe DateTime para representar a data de realização do jogo, com variáveis para o dia, mês e ano. Sugestão: Utilize uma classe já criada anteriormente nas aulas.

d) Crie uma classe JogoBasquetebol que contenha 2 variáveis da classe Equipa (EqCasa, EqVisitante), duas da classe Arbitro (principal, auxiliar) e uma da classe DateTime. Crie os construtores necessários onde os objectos são passados como argumentos para os construtores. Crie propriedades para cada uma das variáveis (estes métodos deverão retornar objectos). Crie um método ToString: “Ovarense - Benfica, 29-09-2003”
e) Teste a classe JogoBasquetebol para um determinado jogo, instanciando correctamente e na ordem certa todos os objectos referidos nas alíneas anteriores e testando os métodos ToString das várias classes.


11. Crie uma hierarquia de classes para professores de uma instituição

A classe de topo, declarada abstract deverá ser designada por Professor (string nome, string nacionalidade, int grau, DateTime dataNascimento) que represente um professor. O grau académico será o seguinte (0 – não disponível, 1-Licenciado, 2 – Mestrado 3 – Doutorado). Deverá ter os seguintes métodos:
Considere apenas um construtor onde são passadas todas as variáveis de classe como argumentos. O construtor deverá verificar se o grau indicado está correcto. Em caso contrário deverá colocar o grau 0 (não disponível). Deverá ainda verificar se todos os nomes do Professor começam por letra maiúscula. Em caso contrário deverá colocar o nome com letra maiúscula no início e o resto do nome em minúsculas. Deverá ainda eliminar todos os espaços no início ou no fim do nome.  ex.: “ joão peDro SoARES  ” 🡪 “João Pedro Soares”
Crie o método GetGrau (deverá retornar uma string com o respectivo grau académico)
A idade do professor deverá ser superior a 18 anos. Em caso contrário será colocado um valor inválido (1/1/1900)
Método ToString “João Pedro Silva, Mestrado, Portugal”. No caso de o grau não estar disponível, este não deverá ser colocado: “Maria Silva, Portugal”
A superclasse Professor deverá ter 3 subclasses: Convidado, Agregado, Associado

Convidado

Variável: string para o Código do Convite, constituído por duas letras e 4 algarismos. As duas letras poderão ser apenas IG, GE, GD ou MM. Exemplo: IG1234. O construtor deverá verificar que o Código obedece a estas condições. Em caso contrário deverá colocar o código XX0000. No caso de as duas letras serem minúsculas, o construtor deverá convertê-las para maiúsculas. 

Override do método ToString() : “Maria Silva, Doutoramento, Portugal, Convidado IG1234”. No caso de o código ser XX0000, este não deverá ser colocado.

Agregado

Variável: Data da agregação (utilize uma variável  DateTime)

Override do método ToString() : “João Pedro Silva, Mestrado, Portugal, Agregação em 22/11/2004”

 Associado

Variável: Tipo de contrato (0 – Não definido 1- Exclusividade, 2 – Integral, 3 – Parcial) O construtor deverá verificar se o valor está correcto. Em caso contrário deverá colocar o mesmo a zero (não definido). 

Método getContrato() que deverá retornar uma string indicando o tipo de contrato. 

Override do método ToString() : “João Pedro Silva, Mestrado, Portugal, Exclusividade”.

Teste as subclasses. 
Teste as classes com uma aplicação. Crie um vector com 6 elementos da classe Professor. Instancie 2 objectos de cada uma das subclasses (6 elementos no total) . Utilizando Polimorfismo, atribua cada um destes objectos a um elemento do vector. Num ciclo sobre o vector Professor, teste os métodos ToString() das 3 subclasses. Não é necessário introduzir valores através de caixas de texto.
Veículos

1. Superclasse VEÍCULO
Crie uma classe declarada como abstract para descrever veículos. A classe deverá ter variáveis para indicar o ano de fabrico (inteiro) e o nome da marca (string).
Construtor que aceite as duas variáveis de classe como argumentos. O ano de fabrico deverá estar entre 1900 e 2005. No caso de o valor do ano de fabrico estar fora deste intervalo, ele será colocado no valor 0 (zero). O nome da marca não deverá exceder os 20 caracteres e será truncado nos 20 caracteres em caso contrário. 
Método ToString() que retorne o nome da marca e o ano de fabrico. Se o ano de fabrico for zero, o método apenas retornará a marca do veículo. Exemplo: “Ferrari 1998”
Propriedades.. 
2. Subclasse AUTOMÓVEL
Crie uma subclasse de Veículo, designada por Automóvel
A classe Automóvel deverá possuir as seguintes variáveis e métodos. Variáveis deverão descrever: Matrícula (string), Cilindrada (inteiro), Número de Lugares (inteiro)
Construtor que receba todas as variáveis de classe como argumentos. A matrícula deverá ser uma string de 6 caracteres onde se dê um dos seguintes casos: 2 letras + 4 algarismos ; 2 algarismos + 2 letras + 2 algarismos ;  4 algarismos + 2 letras. No caso de a matrícula não cumprir estas condições, esta será colocada com a string “XXXXXX”. A cilindrada deverá ter um valor positivo - em caso contrário deverá ser colocada a -1. O número de lugares deverá estar entre 1 e 9 - em caso contrário será colocado a zero. 
Propriedades..
Método ToString() que utilize o método ToString() da Superclasse e apresente acrescente a matrícula, cilindrada e número de lugares. As variáveis só deverão surgir se tiverem valores válidos. Exemplo: “Ferrari, 1998,  33-41-NA,  2000 cc, 4 lugares” 
Crie um método ComparaCarro() que receba um Automóvel como argumento e retorne um valor booleano indicando se o automóvel tem a mesma matrícula e Cilindrada. Se o automóvel passado como argumento tiver exactamente a mesma matrícula e cilindrada do objecto, o método deverá retornar o valor booleano true. 
3. Subclasse BICICLETA 
A subclasse BICICLETA deverá possuir as seguintes variáveis e métodos:
Variáveis: Número de mudanças (inteiro). Concelho onde está registada (string). Tipo (inteiro de acordo com os seguintes valores: 0 – Montanha; 1 – Corrida; 2 – BMX; 3 – Mista)
Construtor que receba as variáveis de classe como argumentos. O número de mudanças deverá ser positivo (senão será colocado a -1). O tipo da bicicleta deverá ser um dos valores indicados, senão será colocado a -1. 
Método ToString() que utilize o método ToString() da superclasse e acrescente o tipo de bicicleta (a string, não o número!), se este for um valor válido. Exemplo: “Ginga 2001 BMX”. 
4. Aplicação
Crie um vector de Veículo com 5 elementos. Usando Polimorfismo, coloque no vector 5 objectos: instancie 3 objectos do tipo Automóvel, sendo que 2 dos quais deverão ter a mesma matrícula e a mesma cilindrada. Instancie 2 objectos do tipo Bicicleta com variáveis ao seu critério.
Utilizando um ciclo para percorrer o vector de Veículo, apresente o resultado do método ToString() para os 5 objectos. 
Teste o método comparaCarro() entre os 3 objectos do tipo Automóvel.   

Elemento

Crie uma classe Elemento declarada como abstract para descrever elementos de uma equipa de basquetebol. A classe deverá ter variáveis para indicar o nome (string), nº de BI (string 9 algarismos), e a data de nascimento (classe DateTime). O nome deverá estar limitado a 20 caracteres senão será truncado. O BI deverá ter 9 dígitos e apenas ser constituído por algarismos (no caso de alguma destas restrições não ser verificada, o BI deverá conter a string “000000000”.  A data de nascimento não poderá ser superior à data actual, senão será colocada na data actual
Crie as propriedades e construtor. 
Método ToString() que retorne o nome e a idade “João Silva, 15 anos”. No caso da idade, esta só deverá ser apresentada se não contiver o valor zero.
Método Idade() que retorne a idade do jogador (sugestão: use o método Subtract de DateTime)
Método ComparaIdade() que receberá um objecto do tipo Elemento como argumento e retornará um valor inteiro correspondendo à diferença de idades entre os elementos (positiva se o elemento passado como argumento for mais velho do que o objecto em causa). 
Método DiasParaAniversario() que indique quantos dias faltam para o aniversário do elemento.
Crie uma subclasse de Elemento, designada por Jogador
A classe Jogador deverá possuir as seguintes variáveis e métodos. As variáveis deverão descrever o número da camisola e o número de pontos marcados em cada encontro na temporada (um vector de inteiros). O número da camisola deverá ter dois algarismos, sendo ambos entre 0 e 5. Em caso contrário o número será colocado a zero. O vector deverá ter valores inteiros iguais ou superiores a -1. No caso de o vector ter algum valor inferior a -1, este será colocado a -1 (-1 indica que o jogador não realizou o jogo). 
Construtor onde são passadas todas as variáveis de classe como argumentos, incluindo um vector de inteiros com os pontos.
Construtor onde são passadas todas as variáveis excepto o vector de pontos que será colocado todo a -1 (neste caso o vector terá 10 posições).
 (1) Método GetPontos() que retorne o número total de pontos até ao momento. Não somar os valores -1!
 (2) Método ToString() que utilize o método toString() da Superclasse e apresente acrescente o número da camisola  e o número total de pontos até ao momento. 
 (1) Método ActualizaPontos(), que receba um inteiro como argumento (o número de pontos num determinado jogo), e coloque esse valor no vector, na primeira posição disponível (ou seja, a primeira posição que contenha um valor igual a -1). No caso de o vector estar todo preenchido, o método não realizará qualquer função.
Teste a classe criando 6 jogadores e testando todos os métodos referidos. 
Zoo
Um jardim zoológico pretende criar um sistema de registo e pesquisa dos animais existentes no zoo. Para isso criou uma hierarquia: 
O topo da hierarquia é designado por Animal. Como cada animal tem um nome, esta classe deverá ter uma variável para o nome, uma variável para a data de nascimento e uma variável para a secção onde se encontra (uma letra maiúscula de A-F).
Deverá ter uma subclasse Macaco (com variáveis para a espécie, peso e altura), uma subclasse Ave (com variáveis para a espécie, envergadura de asa – cm e uma variável para o país de origem), e uma subclasse Elefante (com variáveis para o peso, altura, cor e para a indicação da origem – Africano ou Asiático). 
Construa um interface gráfico para introdução de valores, incluindo um processo para escolher o tipo de animal. 
O programa deverá permitir a inserção e remoção de objectos. 
Deverá permitir a pesquisa por nome (indicando o tipo de animal) e uma listagem geral ou por tipo de Animal. Também deverá permitir uma pesquisa por ano de nascimento. 


Delegates – Ordenação Polimórfica

Para o exemplo dos Veículos, crie uma classe delegada para a ordenação polimórfica usando as variáveis da classe de topo (ano de fabrico – ascendente e descendente; nome da marca – ordem alfabética ascendente e descendente). Teste com um vector de objectos do tipo Veículo.
Para a hierarquia FormaGeometrica, crie uma classe delegada que permita ordenar por área, nome e volume, de forma descendente e ascendente. 

Sobrecarga (Overload) de Operadores

Faça o overload de operadores aritméticos para aritmética de fracções utilizando a classe Racional. 
A partir da classe Rectângulo e da classe Paralelipipedo, crie um overload do operador soma para somar dois rectângulos. O resultado será um Paralelipipedo. Use o maior dos lados de um retângulo para a 3ª dimensão do Paralelipipedo.  
Em FormaGeometrica, crie um overload do operador  + para somar Triângulos (objectos da classe Triângulo). O resultado será um Triângulo cujos lados correspondem aos 3 maiores lados dos 2 Triângulos. Crie o overload do operador % que opere dois triângulos dando como resultado a relação entre as áreas dos triângulos (um valor double). Crie o overload do operador / para dividir um triângulo por um valor double (positivo), dividindo todos os lados do triângulo por este número. Sugestão para projecto: Sugira possíveis overloads para operadores para operar outras figuras geométricas (por exemplo, somar duas esferas dando como resultado uma esfera com a soma dos volumes, a soma de dois quadrados poderá resultar num rectângulo, etc.).  

Revisão POO
Funcionário
1. Crie uma classe abstracta Funcionario para descrever um funcionário de uma empresa. Deverá ter variáveis para descrever o nome (string) e a data de nascimento (DateTime). Crie as propriedades. Restrições: A data de nascimento não poderá ser inferior a 1900 nem superior a 18 anos antes da data presente. Em qualquer dos casos será colocada no dia 1 de Janeiro de 1900. O método ToString retornará o nome do funcionário e a data de nascimento (apenas se esta não for 1/1/1900). 
2. Crie uma classe Automovel para descrever um automóvel que será distribuído a alguns funcionários da empresa. Variáveis: Marca (string), Modelo (string), Matrícula (string), ano de fabrico (inteiro). Restrições: a matrícula deverá corresponder a uma matrícula portuguesa. Em caso contrário será colocada no valor (“XXXXXX”). A idade do carro não poderá ser inferior a zero nem superior a 10 anos. Em caso contrário o ano será colocado em 0. Crie as propriedades. O método ToString deverá apresentar a marca, matrícula (se for válida) e ano de fabrico (apenas se for diferente de zero).
3. Crie uma classe Tarefa para descrever uma determinada tarefa atribuída a um funcionário. Variáveis: data de início e data prevista de fim (ambas DateTime) código de tarefa (string) Esta string poderá ter dois a 4 caracteres alfabéticos maiúsculos seguidos de 1 ou dois algarismos. Não poderá ter qualquer outro carácter. Os caracteres minúsculos serão convertidos para maiúsculos. No caso deste código não ser válido deverá ser colocado em “XX0”. A data de fim não poderá ser anterior à data de início (em caso contrário será colocada exactamente um ano depois da data de início). Crie um overload do operador % que receba duas Tarefas como argumentos e retorne um valor booleano que será true se as tarefas tiverem o mesmo código (ignorando maiúsculas e minúsculas) e as mesmas datas de início e fim (false no caso de alguma das variáveis ser diferentes). Crie um método que retorne a duração da tarefa em dias. 
Crie duas subclasses de funcionário: Associado e Director.
4. A classe Director deverá ter uma variável para descrever o departamento (string) e um objecto da classe Automovel. Não há restrições. Propriedades. O método ToString deverá retornar a informação de funcionário, a marca do automóvel atribuído e o departamento.  
5. A classe Associado terá variáveis a data de associação (DateTime) e um vector de tarefas (classe Tarefa). Não há restrições. O método ToString deverá retornar a informação de funcionário, o ano de associação e o número de tarefas em que o Associado está envolvido. 
6. Teste com um vector de 8  funcionários. 4 directores e 4 associados. Instancie 4 veículos, sendo que dois deverão ter a mesma marca. A cada um dos directores será atribuído um veículo. Aos Associados será atribuído um vector de tarefas. Para isso instancie 4 tarefas (t1, t2, t3, t4) e 4 vectores de tarefas cada um com duas tarefas {t1, t2}, {t2, t3}, {t1,t3}, {t4, t1}. Cada um destes vectores será atribuído a um Associado. 
7. Crie um método que receba um vector de Funcionários como argumento, e retorne o número de marcas diferentes de automóveis atribuídas aos directores.
8. Crie um método que receba como argumentos um vector de Funcionários e uma string (correspondendo a um código de uma determinada tarefa) e retorne um vector de Funcionários a que esteja atribuída esta tarefa. Teste com uma string introduzida pelo utilizador correspondendo ao código de uma das tarefas instanciadas. 
9. Apresente o vector de Funcionários ordenado da seguinte maneira: primeiro por tipo (Directores e depois Associados). Os directores serão ordenados por ordem alfabética. Os Associados por data de associação. 

SUPERMERCADO
Crie uma pequena estrutura de dados Cliente-Fatura-Produto para um supermercado com os construtores e métodos que achar necessários. 
Crie uma classe de topo designada por Produto (string nome, decimal preco, int quantidade). A classe Produto deverá ter duas classes derivadas: Alimentar (DateTime validade) e Eletronica (string marca, string tipo).  
Crie uma classe Cliente (string nome, string NIF). 
Crie uma classe Fatura que deverá ter um Cliente e uma lista (vetor, lista, Collection) de Produto. A classe Fatura deverá também ter uma data de emissão (DateTime) e um método Total() que retorne o valor total da fatura (decimal). O método toString() deverá retornar o nome do cliente, a data da fatura e o valor total. 
Instancie um Cliente, dois produtos Alimentar e dois produtos Eletronica. Crie uma Fatura com estes objetos e com a data de hoje. Apresente o resultado numa label o MessageBox. 

ISMAI
Requisitos 
Desenvolva um sistema de informação para descrever cursos do ISMAI. Deverá ter as seguintes classes:
Curso
Esta classe deverá ter variáveis para descrever a designação do curso por extenso e as suas iniciais (ex. Informática de Gestão, IG). Deverá ainda ter uma variável inteira para indicar o número de anos lectivos do curso. 
Cadeira
Esta classe deverá ter variáveis para descrever o curso, o docente, o nome da cadeira, o número de créditos ECTS, o ano lectivo da cadeira, uma variável indicando a duração da cadeira (primeiro semestre, segundo semestre ou anual), e a carga horária semanal. O ano lectivo da cadeira não poderá ser inferior a 1 ou superior ao número de anos lectivos do respectivo curso. 
Docente
O docente deverá ter variáveis de classe para descrever o grau académico (licenciado, mestrado ou doutorado), o primeiro nome, o último nome, correio electrónico e as cadeiras que lecciona.
Estruture o modelo estático para este sistema de informação de acordo com o referido nos pontos anteriores. 
Modelo dinâmico - PESQUISAS
O sistema deverá permitir:
1. Deverá ter um botão que forneça uma listagem, em ordem alfabética do último nome, de todos os docentes do curso, apresentando a inicial do primeiro nome e o último nome. 
J. Abreu
P. Bastos
A. Bramão
H. Chadinho
V. Satinas
2. Uma drop down com o nome de todos os docentes e que indique a carga horária semanal do docente seleccionado no primeiro e no segundo semestre. 
3. Um conjunto de Radio Buttons com as indicações (Licenciado, Mestrado, Doutorado). Ao ser seleccionado um destes botões, o sistema deverá apresentar o número total de créditos ECTS leccionados pelos professores da categoria seleccionada. Por exemplo, se for seleccionado o botão “Doutorado” o sistema poderá apresentar o número “25” indicando o número de créditos leccionados por professores doutorados.
Notas:
O sistema deverá ter controlo de erros e excepções.
Não é necessário desenvolver uma base de dados. O sistema deverá ter um botão que permita instanciar um conjunto de objectos de cada classe. Deverá apenas instanciar um curso, um mínimo de 5 docentes do curso e um mínimo de 8 cadeiras, distribuídas pelos docentes referidos. 
Crie propriedades para as variáveis com as restrições que achar conveniente. 
Cada classe deverá ter os handles apropriados para as outras classes. 
Interface gráfico
O Interface gráfico deverá ser muito simples. Apenas conterá um botão que permita instanciar um conjunto de objectos (como referido nas notas), botões, drop down e caixas de texto para as pesquisas e caixas de texto ou labels para apresentação dos resultados. 

Futebol
O Sistema de Classes deverá permitir a criação de modelos para os participantes de cada equipa no mundial de futebol: Jogadores, Técnicos e Dirigentes.  Este sistema pretende apenas modelar cada uma das equipas, não os jogos, árbitros, estádios, etc. 
A informação associada a cada um destes intervenientes será a seguinte:
Todos os intervenientes: Nome, Data de Nascimento, País que representa. 
Jogadores: Número da Camisola, número de golos marcados no torneio até ao momento. 
Técnicos: Especialidade (Principal, Adjunto, Preparador Físico, Médico)
Cada equipa só p oderá ter um técnico principal e no máximo 2 técnicos adjuntos. Poderá ter um número ilimitado de qualquer das outras categorias. 
Dirigente: Código de acreditação (constituído por duas letras e 3 algarismos) Exemplo: PT123
Os casos de utilização são os seguintes:
Ordenação de todos os elementos das seguintes formas:
Primeiro por tipo (Jogador, Técnico, Dirigente) e depois por idade (data de nascimento). 
Apenas por data de nascimento.
Primeiro por pais e depois por ordem alfabética de nome. 
Apenas os jogadores, por número de golos marcados, não indicando os jogadores que até ao momento tiverem zero golos marcados. 
Um botão que indique a média de idades por país. Os países deverão ser apresentados por ordem ascendente de média de idades. 
Um botão que indique o melhor ou os melhores marcadores da cada país ( e o respectivo número de golos marcados). Se não houver golos marcados o sistema não deverá indicar qualquer jogador. Se houver mais do que um jogador com o mesmo número de golos, estes deverão ser apresentados por ordem alfabética. 
Um botão que indique quais os participantes que terão o seu aniversário durante o campeonato do mundo (de 9 de Junho a 9 de Julho de 2006 inclusive). Deverá indicar uma lista de participantes, ordenada por ordem de aniversário (não por data de nascimento), indicando a data correspondente e ainda o Nome, País que representa, idade no dia do aniversário (ou seja, quantos anos cumpre nesse dia). 
Notas:
O sistema deverá permitir a introdução de dados através do interface gráfico e deverá guardar os dados numa base de dados simples (poderá, em alternativa, usar ficheiros). A escolha do tipo de participante deverá ser feita através de Radio Buttons, sendo apresentadas as caixas de texto ou Drop Down correspondentes a este tipo específico. A escolha do país que representa deverá ser feita através de uma Drop Down onde colocará os países participantes (para simplificar coloque apenas 4 países). 
As ordenações deverão ser feitas de forma polimórfica, através de classe(s) delegada(s). O sistema deverá apresentar uma lista dos participantes, indicando o país, nome, Tipo (Jogador, Dirigente ou Técnico) e idade. 
A utilização de uma hierarquia de classes é aconselhada. 
Escolha os construtores e métodos que lhe pareçam mais adequados. 

FESTIVAL
Requisitos 
Desenvolvimento de um sistema de informação para um festival de música de Verão. O festival vai decorrer nos dias 10, 11 e 12 de Outubro. O sistema deverá guardar informação sobre os participantes: Estes poderão ser de 3 tipos: músicos, técnicos, organização. Deverá ainda ter classes para guardar informação sobre as bandas que actuam em cada um dos 3 dias no sentido de  elaborar um calendário de concertos. Por fim deverá permitir um conjunto de pesquisas. 
Participante
Todos os participantes deverão ter variáveis para guardar o nome, nacionalidade e data de nascimento. A data de nascimento nunca poderá ser superior à data actual. Em caso contrário, será colocada na data actual. 
Técnico
Os técnicos deverão conter informação sobre a empresa a que pertencem. Os técnicos poderão, ou não, estar ligados a uma banda. 
Músico
Os músicos deverão ter informação sobre o instrumento que tocam (p. exº Vocalista, baixista,…). 
Organização (staff)
Os membros da organização poderão ser de 3 tipos: Administrativo, técnico ou segurança. A classe deverá possuir esta informação, bem assim como o nome da empresa a que pertencem. 
Banda
A banda é constituída por músicos e técnicos. A classe deverá ter informação sobre o nome da banda e data da sua constituição. Deverá ainda incluir o dia da actuação (só poderá ser um dos 3 dias referidos acima). 
Interface
O interface gráfico deverá permitir a introdução de dados sobre os elementos da banda (músicos e técnicos), nome da banda, data de formação da mesma, dia da actuação, etc., de modo a permitir a instanciação de um objecto do tipo banda. 
Deverá ter um botão para instanciar outros objectos directamente, se necessário, ou no caso de não ter sido realizada a alínea anterior. 
Pesquisa
O sistema deverá permitir as seguintes pesquisas:
Apresentação das bandas que vão actuar em cada um dos dias, ordenado por dias.
Pesquisa de uma banda pelo nome, indicando a sua constituição (apenas músicos) e data de formação. 
Apresentar uma lista de todos os técnicos de todas as bandas (não músicos)

Projectos de Modelização OO

Sistema de Inscrições numa faculdade. Classes Professor, Aluno, Curso, Cadeira, Horário, Currículo. 

Sistema de modelização de um torneio de futebol. Classes Participante, Jogador, Técnico, Árbitro, Equipa, Jogo, Grupo. Utilização de uma classe de Controlo. 

Crie um sistema hierárquico de classes em C# para um sistema de gestão dos resultados desportivos no Europeu de Futebol sub-21, realizado em Portugal. Este sistema deverá permitir modelizar os resultados desportivos em classes apropriadas. 
O campeonato realiza-se da seguinte maneira: Existem 2 grupos de 4 equipas cada, onde cada equipa realiza 3 jogos contra as outras equipas do grupo. Os resultados têm as seguintes pontuações:
Vitória: 3 pontos, Empate: 1 ponto, Derrota: 0 pontos.
O vencedor de um grupo defrontará o segundo classificado do outro grupo numa meia final. Os vencedores destes encontros encontrar-se-ão na final. 
O sistema deverá incluir informação para as equipas, grupos, jogos até à final. Devrá conter informação básica sobre jogadores. Deverá incluir informação sobre o árbitro principal de cada encontro (nome e nacionalidade) e sobre os técnicos (nome) de cada equipa. A informação de cada jogo deverá incluir a data e hora de realização do mesmo, o estádio onde se realiza, bem assim como a informação sobre as equipas participantes, o grupo (poderá ser meia final ou final) e o resultado do mesmo. 
O sistema deverá permitir realizar diversas operações. Neste protótipo deverá apenas incluir duas ou três operações possíveis (por exemplo, obter informação sobre resultados dos jogos, classificações, etc.). 
Desenvolva o modelo estático que lhe pareça adequado e implemente-o em C#. Escolha as estruturas adequadas. Em relação ao modelo dinâmico coloque alguns métodos que lhe pareçam convenientes para realizar as operações que se propõe (poderá apenas incluir os cabeçalhos dos métodos). Comente convenientemente o programa. 
Realize um interface gráfico, onde introduzirá informação sobre as equipas e jogos. 

Crie um modelo estático e dinâmico para o sistema de Paragens/carreiras de autocarros que permita: 
Apresentar o percurso de uma carreira
Indicar quais as carreiras que passam numa determinada paragem
Determinar que carreiras devem ser utilizadas para percorrer o caminho entre duas paragens

A paragem deverá ter uma indicação do código de paragem e concelho onde se encontra. Avançado: considere também os horários das carreiras e os percursos mais curtos em termos de tempo. 

Sistema de reservas para um consultório médico (exemplo: dentista) baseado num calendário. 
Crie uma estrutura de dados Receita-Cliente-Medicamento. A Receita tem vários medicamentos (uma lista) e um cliente. Teste o programa instanciando um cliente, vários medicamentos e uma receita. 
Crie uma estrutura de dados Docente-Cadeira-Aluno. A cadeira é lecionada por um Docente e tem uma lista de alunos. Os docentes e os alunos são classes derivadas de uma classe de topo abstract Pessoa.Teste o programa instanciando um Docente, uma lista de alunos e uma Cadeira.  


Estruturas complexas.
Utilizando a estrutura Stack crie um sistema para um porto de contentores onde existem 4 pilhas de contentores (classe Contentor). O sistema deverá poder adicionar, retirar e mover contentores entre as pilhas. 
Utilizando a estrutura HashTable crie uma aplicação que coloque nomes e respectivos bilhetes de identidade numa estrutura de Hash. O utilizador deverá poder inserir, eliminar, editar e pesquisar (por nome e por BI).
Utilizando a estrutura SortedDictionary crie  um programa que “traduza” de Português para “linguagem à moda do Porto”. O programa deverá permitir inserir novos termos, eliminar e pesquisar o dicionário.
Utilizando uma lista circular, implemente um programa que simule o “Pim-Pam-Pum” ou a eliminação de Josephus. 
Árvores e árvores binárias de pesquisa.

Organigrama


Grafos

Implemente os algoritmos:
MST, 
Caminho mais curto, 
Pesquisa em rede, 
TSP, 
Inspector de estradas, 
Fluxo máximo. 

MultiThreading


Referências

http://www.devhood.com/training%5Fmodules/dist%2Da/WritingOOCSharp/

http://msdn.microsoft.com/library/default.asp?url=/library/en-us/csref/html/vcoricsharptutorials.asp

http://www.c-sharpcorner.com/

http://www.linhadecodigo.com.br/desenvolvimento/csharp.asp

http://www.csharpfriends.com/



