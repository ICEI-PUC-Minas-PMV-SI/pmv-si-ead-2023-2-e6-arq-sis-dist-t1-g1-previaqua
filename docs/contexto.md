# Introdução

Este projeto aborda a carência de previsões meteorológicas precisas e alertas de inundações, visando proteger comunidades vulneráveis. Desenvolveremos um sistema de informações climáticas em tempo real, abrangendo públicos diversos, desde moradores em áreas de risco até autoridades e empresas locais. A relevância desse projeto se baseia na necessidade vital de proteção e na possibilidade de replicação do mesmo.

## Problema

A falta de previsões meteorológicas e alertas de inundações precisos e antecipados pode levar a danos significativos em comunidades propensas a inundações. As comunidades urbanas em regiões de risco são as mais afetadas, como, por exemplo, as comunidades próximas a rios, sistemas de esgoto com drenagem inadequada, chuvas intensas ou encostas. As inundações representam uma ameaça importante às vidas, propriedades e infraestruturas, podendo levar a perdas econômicas e sociais consideráveis.

Problemas de comunicação entre os sistemas de alerta precoce e a população residente em áreas de risco podem levar a um agravamento da situação, aumentando o potencial de danos e atrasando a resposta eficaz diante de ameaças iminentes, comprometendo assim a segurança e o bem-estar de todos os envolvidos. 

## Objetivos

- **Fornecer Previsões Meteorológicas:** Nosso aplicativo visa oferecer previsões meteorológicas confiáveis e precisas para os usuários, permitindo que eles estejam preparados para condições climáticas adversas.
- **Alertar sobre Inundações Potenciais:** O aplicativo visa fornecer alertas em tempo real sobre condições climáticas que possam levar a inundações, ajudando as comunidades a tomarem medidas preventivas e de segurança.
- **Facilitar o Acesso à Informação:** Nosso objetivo é tornar as informações meteorológicas facilmente acessíveis para usuários de todas as faixas etárias e níveis de familiaridade com tecnologia.
- **Personalização das Preferências:** Pretendemos permitir que os usuários personalizem suas configurações de notificação e visualizem informações meteorológicas relevantes com base em suas preferências individuais.

## Justificativa

A justificativa para o desenvolvimento deste projeto reside na necessidade crucial de enfrentar os danos crescentes causados por inundações e eventos climáticos extremos. A falta de previsões e alertas precisos coloca vidas, propriedades e economias em risco.

No início de 2022, o Brasil enfrentou condições secas em várias regiões, mas eventos significativos de inundações impactaram o país. O Rio de Janeiro sofreu com enchentes mortais em fevereiro, causando 232 óbitos. Esses eventos foram registrados no relatório "Weather, Climate and Catastrophe Insight" de 2023, produzido pela empresa Aon, destacando a necessidade de conscientização diante das mudanças climáticas.

O projeto busca fornecer informações oportunas e relevantes para comunidades em áreas de risco, capacitando-as a se prepararem e responderem de maneira eficaz. Além disso, a natureza potencialmente replicável do projeto o transforma em uma iniciativa de grande valor para impulsionar a resiliência climática.

## Público-Alvo

O público-alvo dessa aplicação é diversificado, abrangendo diferentes perfis de usuários que podem se beneficiar das informações meteorológicas e alertas de inundações. Esses perfis incluem:

1. **Residentes em Áreas de Risco:** Indivíduos que vivem em comunidades urbanas próximas a rios, encostas ou outras áreas propensas a inundações. Esse grupo tem interesse direto nas informações para proteger suas vidas e propriedades.
2. **Autoridades e Gestores Públicos:** Órgãos governamentais, agências de defesa civil e gestores de emergência que precisam de informações precisas para tomar decisões informadas e coordenar ações eficazes em resposta a eventos climáticos extremos.
3. **Empresas e Comércios Locais:** Empresas, comércios e empreendedores que operam em áreas de risco podem se beneficiar ao receber alertas antecipados para minimizar danos a seus estabelecimentos.
4. **Comunidade Científica e Acadêmica:** Pesquisadores e acadêmicos que estudam mudanças climáticas, fenômenos meteorológicos e suas implicações sociais podem usar os dados para análises e pesquisas.
5. **Indivíduos Interessados em Meio Ambiente:** Pessoas interessadas em acompanhar informações climáticas e que desejam contribuir para a resiliência das comunidades podem utilizar a aplicação.
6. **Usuários com Diferentes Níveis de Experiência Tecnológica:** A aplicação é projetada para ser acessível a usuários com diferentes níveis de familiaridade com a tecnologia, permitindo que todos possam aproveitar seus benefícios.

Ao atender a esses diversos perfis de usuários, nosso objetivo é fornecer informações relevantes, personalizadas e de fácil acesso, promovendo a segurança, a conscientização e a preparação diante das ameaças climáticas.

# Especificações do Projeto


As enchentes constituem um desafio relevante em cidades brasileiras, acarretando consequências abrangentes para a população e a infraestrutura urbana. Cerca de 9,5 milhões de brasileiros moram em áreas de risco sujeitas a deslizamentos de terra, enchentes e outros desastres climáticos. A estimativa é do Centro Nacional de Monitoramento e Alertas de Desastres Naturais (Cemaden), vinculado ao Ministério de Ciência, Tecnologia e Inovações.

Essas enchentes resultam em danos físicos, contaminação hídrica e desalojamento, particularmente em regiões densamente povoadas devido à redução da absorção de água por superfícies impermeáveis. O risco é ainda maior em áreas de encosta, onde podem ocorrer deslizamentos de terra.

A mitigação desse problema requer um enfoque abrangente que abarque o planejamento urbano, a infraestrutura de drenagem, a monitorização climática e a conscientização pública. A implementação de políticas de prevenção é imperativa para salvaguardar vidas e meios de subsistência, especialmente nas comunidades mais vulneráveis.

Em suma, as enchentes nas cidades brasileiras demandam ações coordenadas para minimizar seus impactos. A quantidade de pessoas em áreas de risco, conforme indicada pelo Cemaden, enfatiza a urgência de medidas efetivas para assegurar a segurança e a qualidade de vida de toda a população.

Dados os problemas resultado das enchentes e seus afetados, se torna evidente a necessidade de um dispositivo que informe em tempo hábil ao morador e aos órgãos públicos a localidade, intensidade e grau de risco que a chuva pode trazer para que os impactados se antecipem e tomem as devidas providências.


## Personas

### Persona 1
**Nome**: Moacir Coelho
**Idade**: 54 anos
**Profissão**: Comerciante
**Localização**: Recife, PE

Contexto:
Moacir é um comerciante estabelecido em Recife, uma cidade litorânea que enfrenta problemas sazonais de enchentes devido às chuvas intensas e à proximidade com o mar. Ele é casado e tem dois filhos adultos que moram na mesma cidade.

Objetivos e Necessidades:
Moacir está preocupado com a segurança de sua família e com a possibilidade de danos à sua loja e estoque durante as enchentes. Seu objetivo principal é receber informações precisas e antecipadas sobre a probabilidade de enchentes para tomar decisões bem informadas sobre a proteção de seus bens e de sua família.

Comportamentos e Hábitos:
Moacir costuma assistir aos noticiários locais e acessar sites de meteorologia em seu computador. Ele também confere os níveis dos rios nas redondezas para avaliar o risco de enchentes. Além disso, ele gosta de participar de grupos de moradores nas redes sociais para compartilhar informações e dicas de prevenção.

Desafios e Motivações:
Os desafios de Moacir incluem a dificuldade em acessar informações atualizadas em tempo real sobre os níveis dos rios e previsões de chuvas intensas. Sua motivação é encontrar uma solução prática e confiável que o ajude a tomar decisões rápidas e eficazes para proteger seus bens e sua família.

Histórias e Cenários:

Cenário 1: Moacir está na loja quando começa a chover intensamente. Ele verifica seu smartphone em busca de informações sobre as previsões de enchentes e fica ansioso para obter dados precisos para saber se deve fechar a loja mais cedo e adotar medidas de proteção.

Cenário 2: Moacir recebe um aviso de chuvas fortes no celular enquanto está em casa com sua família. Ele compartilha imediatamente as informações com sua esposa e filhos e começa a movimentar estoques mais valiosos para áreas mais elevadas da loja.

Objetivos do Projeto:
Para o projeto de alerta de enchentes, Moacir seria um usuário valioso, buscando informações atualizadas e práticas para tomar decisões de negócios e proteção da família durante episódios de chuvas intensas e enchentes. Sua participação no projeto contribuiria para a criação de um sistema de alerta eficaz e relevante para os empresários e residentes de áreas propensas a enchentes em Recife.

### Persona 2
**Nome**: Ana Clara
**Idade**: 18 anos
**Ocupação**: Estudante universitária
**Localização**: São Paulo, SP

Contexto:
Ana Clara é uma estudante universitária que vive em São Paulo, uma cidade que pode enfrentar enchentes durante o período de chuvas intensas. Ela mora com sua família em um apartamento na zona urbana da cidade.

Objetivos e Necessidades:
Ana Clara está preocupada com a segurança de sua família e a possibilidade de interrupções em sua rotina de estudos devido a enchentes. Seu principal objetivo é receber alertas rápidos e confiáveis para que ela e sua família possam se preparar adequadamente e evitar problemas de mobilidade durante as enchentes.

Comportamentos e Hábitos:
Ana Clara costuma verificar o aplicativo de previsão do tempo em seu smartphone todas as manhãs para saber o que esperar em relação ao clima. Ela também está ativa nas redes sociais, onde compartilha informações e dicas de prevenção com amigos e familiares.

Desafios e Motivações:
Os desafios de Ana Clara incluem a necessidade de informações claras e atualizadas que possam ajudá-la a se preparar para a escola e outras atividades, mesmo em condições climáticas adversas. Sua motivação é evitar atrasos e transtornos devido a enchentes, garantindo que possa continuar com sua rotina normal.

Histórias e Cenários:

Cenário 1: Ana Clara acorda cedo para ir para a universidade e verifica seu celular para verificar as condições climáticas. Ela fica aliviada ao ver um alerta de chuva intensa e decide pegar o metrô em vez de ir de ônibus, para evitar possíveis atrasos devido a enchentes nas ruas.

Cenário 2: Ana Clara está estudando em casa quando começa a chover forte. Ela recebe um alerta em seu smartphone sobre a possibilidade de enchentes na região e avisa seus pais para estarem preparados, caso a situação se agrave.

Objetivos do Projeto:
No projeto de alerta de enchentes, Ana Clara representaria uma usuária jovem e conectada, interessada em receber informações em tempo real para planejar suas atividades diárias e garantir sua segurança e a de sua família. Sua participação ajudaria a criar um sistema de alerta que atendesse às necessidades das gerações mais jovens e tecnologicamente envolvidas.


### Persona 3
**Nome**: Maria Cleuza
**Idade**: 72 anos
**Ocupação**: Aposentada
**Localização**: Salvador, BA

Contexto:
Maria Cleuza é uma aposentada que vive em Salvador, uma cidade costeira que pode enfrentar enchentes devido às chuvas intensas e à proximidade do mar. Ela mora sozinha em uma casa térrea em um bairro mais antigo da cidade.

Objetivos e Necessidades:
Maria Cleuza está preocupada com sua segurança durante as enchentes e deseja receber informações confiáveis que a ajudem a se proteger. Sua principal necessidade é ser alertada de forma simples e acessível, já que ela não está acostumada a utilizar computadores ou smartphones.

Comportamentos e Hábitos:
Maria Cleuza confia principalmente na televisão e no rádio como suas fontes primárias de informações. Ela gosta de ler o jornal local todas as manhãs e confiar nas recomendações dos vizinhos e amigos em situações de risco.

Desafios e Motivações:
Os desafios de Maria Cleuza incluem sua falta de familiaridade com tecnologia, o que a impede de receber alertas online ou via smartphone. Sua motivação é receber alertas de maneira simples e compreensível, para poder agir prontamente diante de possíveis enchentes.

Histórias e Cenários:

Cenário 1: Maria Cleuza está assistindo à televisão à noite quando um anúncio sobre previsões de chuvas fortes aparece. Ela anota as informações importantes e coloca o papel na geladeira como lembrete para ficar atenta às condições climáticas.

Cenário 2: Durante um almoço com amigos, um vizinho menciona que ouviu no rádio sobre a possibilidade de chuvas intensas. Maria Cleuza presta atenção ao que o vizinho diz e decide se informar mais sobre as condições climáticas através do noticiário da televisão.

Objetivos do Projeto:
Para o projeto de alerta de enchentes, Maria Cleuza representa um público mais idoso e que não está familiarizado com a tecnologia moderna. O desafio é fornecer informações acessíveis por meio de canais tradicionais, como televisão e rádio, para garantir que ela possa receber alertas e se proteger em situações de risco. Sua participação é crucial para garantir que pessoas de todas as idades se beneficiem do sistema de alerta.

### Persona 4
**Nome**: Davi
**Idade**: 3 anos
**Localização**: Curitiba, PR
**Ocupação**: Criança em fase pré-escolar

Características:
Davi é uma criança curiosa e enérgica, cheia de imaginação e desejo de explorar o mundo ao seu redor. Ele está na fase pré-escolar, frequentando uma creche e aprendendo a interagir com outras crianças e adultos.

Comportamentos e Hábitos:
Davi gosta de brincar ao ar livre, explorar o jardim, brincar com brinquedos coloridos e passar tempo com seus colegas de creche. Ele ainda não tem habilidades de leitura ou compreensão de conceitos complexos.

Desafios e Motivações:
Davi não possui a capacidade de entender informações complexas ou lidar com situações de risco, como enchentes. Ele é motivado principalmente pelo desejo de diversão, aprendizado e interação com os outros. Seu desafio é depender da orientação de adultos para garantir sua segurança.

Objetivos do Projeto:
Embora Davi não seja o usuário principal de um sistema de alerta de enchentes, ele representa a importância de proteger os mais jovens e vulneráveis em situações de risco. O sistema de alerta deve ser eficaz o suficiente para que os adultos ao seu redor possam tomar medidas adequadas para sua segurança e proteção durante eventos climáticos extremos.

### Persona 5
**Nome**: Ravi Januzzi
**Idade**: 34 anos
**Profissão**: Engenheiro de Software
**Localização**: Brasília, DF

Contexto:
Ravi é um engenheiro de software que vive em Brasília, uma cidade sujeita a fortes chuvas em certas épocas do ano. Ele é solteiro e mora sozinho em um apartamento próximo ao centro da cidade.

Objetivos e Necessidades:
Ravi está interessado em receber alertas precisos e oportunos sobre enchentes para garantir sua segurança e proteção de seus pertences. Além disso, ele quer estar bem informado para evitar problemas no deslocamento e possíveis atrasos em seu trabalho.

Comportamentos e Hábitos:
Ravi acompanha as condições climáticas através de aplicativos de previsão do tempo em seu smartphone. Ele também lê notícias online e é ativo em redes sociais, compartilhando informações relevantes com amigos e colegas.

Desafios e Motivações:
Ravi enfrenta o desafio de equilibrar sua rotina de trabalho e vida pessoal, enquanto se mantém informado sobre as condições climáticas. Sua motivação é a segurança pessoal e a conveniência de poder planejar suas atividades diárias de acordo com as condições climáticas.

Histórias e Cenários:

Cenário 1: Ravi está no trabalho quando recebe um alerta em seu smartphone sobre a possibilidade de enchentes em sua área. Ele considera sair mais cedo para evitar problemas no trânsito e garantir que sua casa esteja segura.

Cenário 2: Durante um fim de semana, Ravi planeja um passeio ao ar livre com amigos. Ele verifica o aplicativo de previsão do tempo para se certificar de que o tempo estará bom para a atividade planejada.

Objetivos do Projeto:
Ravi representa um usuário tecnicamente apto e ativo online, que busca informações precisas e convenientes para se proteger e se adaptar às condições climáticas adversas. Sua participação no projeto de alerta de enchentes ajuda a garantir que a solução atenda às necessidades de pessoas engajadas como ele, que desejam otimizar suas atividades com base nas condições climáticas.


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  |Receber alertas de enchentes        | Para poder tomar medidas preventivas para proteger minha família e meu patrimônio                                                          
|Usuário do sistema  |Acessar dados meteorológicos em tempo real e alertas de enchentes |Ajudar as pessoas em emergências e evacuação, se necessário|     
|Usuário do sistema  |Informações detalhadas sobre possíveis áreas de inundações |Melhorar o design de infraestruturas e sistemas de drenagem |
|Usuário do sistema  |Acesso a dados históricos e em tempo real |Melhorar meus estudos sobre padrões climáticos e fenômenos de inundações |
|Administrador       |Alterar permissões                 |Permitir que possam administrar contas |



> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Modelagem do Processo de Negócio 

### Análise da Situação Atual

Apresente aqui os problemas existentes que viabilizam sua proposta. Apresente o modelo do sistema como ele funciona hoje. Caso sua proposta seja inovadora e não existam processos claramente definidos, apresente como as tarefas que o seu sistema pretende implementar são executadas atualmente, mesmo que não se utilize tecnologia computacional. 

# Indicadores de Desempenho

Apresente aqui os principais indicadores de desempenho e algumas metas para o processo. Atenção: as informações necessárias para gerar os indicadores devem estar contempladas no diagrama de classe. Colocar no mínimo 5 indicadores. 

Usar o seguinte modelo: 

![Indicadores de Desempenho](img/02-indic-desemp.png)
Obs.: todas as informações para gerar os indicadores devem estar no diagrama de classe a ser apresentado a posteriori. 

- **Precisão das Previsões:** A precisão das previsões meteorológicas será avaliada comparando as previsões do aplicativo com os dados reais. Buscaremos uma alta taxa de precisão para ganhar a confiança dos usuários.
- **Tempo de Alerta de Inundações:** Mediremos o tempo que leva para o aplicativo emitir alertas sobre condições propícias a inundações após recebermos informações relevantes. Nosso objetivo é fornecer alertas o mais cedo possível.
- **Taxa de Adoção:** Acompanharemos quantos usuários estão adotando o aplicativo em relação à base de usuários total. Uma taxa crescente de adoção indica que estamos atendendo às necessidades dos usuários.
- **Avaliações e Feedback dos Usuários:** Monitoraremos as avaliações e o feedback dos usuários por meio das lojas de aplicativos e canais de suporte. Isso nos ajudará a identificar áreas de melhoria e reconhecer recursos bem-sucedidos.

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)

# Matriz de Rastreabilidade

A matriz de rastreabilidade é uma ferramenta usada para facilitar a visualização dos relacionamento entre requisitos e outros artefatos ou objetos, permitindo a rastreabilidade entre os requisitos e os objetivos de negócio. 

A matriz deve contemplar todos os elementos relevantes que fazem parte do sistema, conforme a figura meramente ilustrativa apresentada a seguir.

![Exemplo de matriz de rastreabilidade](img/02-matriz-rastreabilidade.png)

> **Links Úteis**:
> - [Artigo Engenharia de Software 13 - Rastreabilidade](https://www.devmedia.com.br/artigo-engenharia-de-software-13-rastreabilidade/12822/)
> - [Verificação da rastreabilidade de requisitos usando a integração do IBM Rational RequisitePro e do IBM ClearQuest Test Manager](https://developer.ibm.com/br/tutorials/requirementstraceabilityverificationusingrrpandcctm/)
> - [IBM Engineering Lifecycle Optimization – Publishing](https://www.ibm.com/br-pt/products/engineering-lifecycle-optimization/publishing/)


# Gerenciamento de Projeto

O gerenciamento de projetos é uma disciplina dinâmica e fundamental que visa planejar, organizar, controlar e executar as atividades necessárias para alcançar com sucesso os objetivos do projeto. Esteja você criando um novo produto, desenvolvendo um software inovador, construindo uma infraestrutura complexa ou qualquer outra iniciativa pontual, o gerenciamento de projetos fornece uma estrutura sólida para solucionar desafios e fornecer resultados consistentes.

## Gerenciamento de Tempo

**ETAPA 1: Documentação de Contexto**
- Realizar uma análise detalhada dos requisitos do projeto.
- Definir o escopo do sistema, identificando funcionalidades e recursos principais.
- Elaborar casos de uso detalhados para as diferentes partes do sistema.
- Documentar os requisitos funcionais e não funcionais do sistema.
- Criar um documento de especificações de projeto, descrevendo a visão geral e a finalidade do sistema.

**ETAPA 2: Planejar, Desenvolver e Gerenciar APIs e Web Services**
- Identificar as APIs e serviços web necessários para o sistema.
- Projetar a arquitetura da API, definindo endpoints, métodos e estrutura dos dados.
- Desenvolver as APIs e serviços web de acordo com o projeto.
- Implementar autenticação e segurança nas APIs, se necessário.
- Realizar testes de unidade e integração nas APIs e serviços web.
- Documentar a API, incluindo informações sobre como consumi-la.
  
**ETAPA 3: Planejar, Desenvolver e Gerenciar uma Aplicação Web**
- Projetar a arquitetura da aplicação web, incluindo a estrutura de páginas e fluxos de navegação.
- Desenvolver as diferentes páginas e componentes da aplicação web.
- Implementar recursos interativos, como formulários e elementos de interface.
- Integrar as APIs e serviços web desenvolvidos anteriormente na aplicação.
- Testar a aplicação web em diferentes navegadores e dispositivos.
- Realizar testes de desempenho e otimizar a velocidade da aplicação, se necessário.
  
**ETAPA 4: Planejar, Desenvolver e Gerenciar uma Aplicação Móvel**
- Definir a plataforma-alvo para a aplicação móvel (iOS, Android, etc.).
- Projetar a interface do usuário da aplicação móvel, considerando as diretrizes de design da plataforma.
- Desenvolver as telas e fluxos de navegação da aplicação móvel.
- Integrar as APIs e serviços web relevantes à aplicação móvel.
- Implementar recursos nativos, como notificações push e geolocalização, se necessário.
- Realizar testes em dispositivos reais e emuladores para garantir a compatibilidade e o desempenho.
  
**ETAPA 5: Apresentação**
- Preparar materiais visuais e de apresentação, como slides ou demonstrações.
- Realizar uma apresentação para as partes interessadas, destacando os principais recursos e benefícios do sistema.
- Demonstrar a funcionalidade das aplicações web e móveis, incluindo o uso das APIs e serviços web.
- Receber feedback das partes interessadas e responder a perguntas.
- Fornecer informações sobre como acessar e usar as aplicações após o lançamento.

## Gerenciamento de Equipe

O gerenciamento adequado de tarefas contribuirá para que o projeto alcance altos níveis de produtividade. Por isso, é fundamental que ocorra a gestão de tarefas e de pessoas, de modo que os times envolvidos no projeto possam ser facilmente gerenciados. 

- **Definição de Funções e Responsabilidades:** Cada membro da equipe terá funções e responsabilidades claras para garantir uma divisão eficiente do trabalho e evitar redundâncias.
- **Comunicação Eficiente:** Utilizaremos ferramentas de comunicação interna para manter todos os membros da equipe informados sobre o progresso, desafios e metas alcançadas.
- **Acompanhamento de Tarefas:** Faremos uso de ferramentas de gestão de projetos para atribuir tarefas, definir prazos e monitorar o andamento das atividades.
- **Feedback e Melhoria Contínua:** Incentivaremos um ambiente de feedback aberto, onde os membros da equipe possam compartilhar ideias, sugestões e preocupações para promover a melhoria contínua do projeto.

![Simple Project Timeline](img/02-project-timeline.png)

# Arquitetura da Solução


Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

![Arquitetura da Solução](img/02-mob-arch.png)

## Tecnologias Utilizadas

/*Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.*/

- Linguagens de Programação: C#/.NET
- Frameworks: EntityFrameWork (Backend)
- Bancos de Dados: MySql
- Ferramentas de Modelagem Climática
- Serviços de Notificação em Tempo Real (por exemplo, Firebase Cloud Messaging)
- Ferramentas de Visualização de Dados




## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
