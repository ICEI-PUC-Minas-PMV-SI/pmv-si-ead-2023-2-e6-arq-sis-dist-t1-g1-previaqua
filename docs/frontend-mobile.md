# Front-end Móvel

LINK: https://snack.expo.dev/@bernardocrs/previaqua

O PreviAqua versão mobile permite aos usuários acessar as últimas notícias climáticas, conferir a previsão do tempo da sua cidade e alertar outros usuários de eventos climáticos.

## Tecnologias Utilizadas
As principais tecnologias utilizadas para o desenvolvimento mobile foram:
1 - Linguagens de Programação:
  * HTML;
  * CSS;
  * Javascript

2 - Frameworks e Bibliotecas
  * React Native

Além disso, foi utilizada uma API do INMET em conexão com a aplicação.

## Arquitetura

A arquitetura da aplicação móvel utilizada foi a arquitetura MVC (Model-View-Controller), onde o modelo, ou seja, a parte lógica, foi utilizada uma API para buscar as condições meteorológicas do local desejado. A camada de visão foi desenvolvida para ser fácil e de simples manuseio onde suas funções são intuitivas ao usuário. Já o controle também desenvolvido para ser leve e trazer agilidade ao sistema.

## Modelagem da Aplicação
A aplicação PreviAqua tem uma estrutura de dados que envolve principalmente informações climáticas de diferentes cidades.

API Consulta de Dados Climáticos

Entidades Principais:
Cidade: Representa informações sobre uma cidade específica, incluindo nome, coordenadas geográficas (latitude e longitude) e informações climáticas associadas.
Usuário: Armazena dados de usuários da aplicação, incluindo informações de autenticação e permissões.
Estação Meteorológica: Representa uma estação meteorológica, com informações como código de estação, localização (latitude e longitude), e dados específicos da estação, como temperatura, umidade, pressão atmosférica, etc.

## Projeto da Interface
### Wireframes
![Wireframe](img/wireframe-mobile.drawio.png)

### Design Visual
Optamos por uma interface clean, utilizando uma barra de navegação inferior com três tabs: 
- Feed: primeira página que aparece ao abrir o App. Nela constam notícias recentes sobre questões relacionadas ao clima.
- Previsão: onde o usuário pode digitar o nome da cidade e visualizar informações climáticas em tempo real.
- Alertas: local onde o usuário visualiza alertas emitidos por outros usuários da plataforma sobre enchentes, deslizamentos, alagamentos, etc. O usuário também é capaz de criar um alerta.
Escolhemos ícones facilmente identificáveis que remetem a feed de notícias (jornal), previsão do tempo (nuvem e sol), alerta (exclamação).
A paleta de cores incluem as cores azul, laranja, cinza e roxo; cores essas que remetem às condições climáticas ou estão presentes classicamente em apps de previsão do tempo.

### Layout Responsivo
O aplicativo apresenta práticas de design responsivo, utilizando recursos do React Native para garantir uma experiência de usuário consistente em uma variedade de dispositivos. O uso de fontes com propriedades responsivas garantem que o tamanho da fonte se ajuste proporcialmente ao tamanho da tela. A combinação de unidades relativas, flexibilidade com Flexbox e a utilização eficiente de estados contribuem para um layout que se ajusta dinamicamente, promovendo uma experiência agradável para os usuários em diferentes contextos.

### Interações do Usuário
Visando ser prática e intuitiva, o Front-End Mobile é uma aplicação single-page e tem o objetivo bem simples de fornecer as informações necessárias ao usuário com o mínimo de toque. Com foco na performace, o sistema não possui animações, isso foi pensado para que haja o minínimo de atualizações e interferências externas uma vez que o objetivo é forncer o serviço para pessoas de todas as faixas socioeconônimas e localidades.

## Fluxo de Dados

1 - Abertura do Aplicativo:
   * O usuário abre o aplicativo em seu dispositivo móvel.
     
2 - Interface de Entrada de Dados:
   * O aplicativo exibe uma tela de entrada de dados solicitando que o usuário insira o estado e a cidade que deseja consultar em relação à precipitação.
     
3 - Interatividade com o Front-end:
   *   O usuário insere o estado e a cidade desejados.
   * O front-end valida os dados inseridos para garantir que correspondam a uma localização válida.
  
4 - Comunicação com o Back-end:
   * Após a validação, o front-end envia uma solicitação ao back-end contendo as informações de localização inseridas pelo usuário.
     
5 - Integração com a API do INMET:
   * O back-end faz uma chamada à API do INMET (Instituto Nacional de Meteorologia) para obter informações meteorológicas da região específica fornecida pelo usuário (estado e cidade).
   * A API do INMET retorna os dados meteorológicos, incluindo informações sobre precipitação e volume de chuva para essa região.
     
6 - Processamento dos Dados Recebidos:
   * O back-end processa os dados recebidos da API do INPE para estruturá-los de forma adequada para serem enviados de volta ao front-end.
     
7 - Retorno dos Dados para o Usuário:
   * O back-end envia os dados processados de precipitação e volume de chuva de volta para o front-end.
     
8 - Exibição dos Resultados para o Usuário:
   * O front-end recebe os dados do back-end e os apresenta de forma legível e compreensível para o usuário na interface do aplicativo mobile.
   * O usuário visualiza as informações sobre a precipitação e o volume de chuva na região específica que consultou.
     
9 - Possíveis Ações do Usuário:
   * Com base nas informações fornecidas, o usuário pode tomar decisões, como planejar atividades ao ar livre, se preparar para possíveis alagamentos ou deslizamentos de terra, etc.

## Requisitos Funcionais

* O sistema deve permitir que o usuário entre com sua localidade.


## Requisitos Não Funcionais

* O software deve ser de fácil uso e intuivo.
* O sistema deve ser capaz de retornar a resposta ao usuário em menos de 30 segundos.
* O sistema deve estar disponível 99,97% do tempo.
* O sistema deverá conter uma interface fácil de mexer e rápida para buscar informações. 
  


## Considerações de Segurança

## Autenticação e Autorização:

1. Utilização de serviços de autenticação da AWS, como AWS Identity and Access Management (IAM), para controlar o acesso aos recursos.

## Proteção contra Ataques:
1. Configuração de grupos de segurança e ACL para controlar o tráfego de entrada/saída para instâncias EC2.

2. Utilização de serviços como AWS WAF (Web Application Firewall) para proteger contra ataques comuns na web.

## Outros serviços de segurança:

1. Utilização do Cloudtrail para análises e rastreio de ações
   
2. Utilização do GuardDuty para proteger a instância em nível de camada de aplicação contra agentes maliciosos


## Implantação:

## Criação de Recursos na AWS:

1. Criar instâncias EC2, configurar grupos de segurança, criar bancos de dados, definir políticas IAM, etc.

## Instalação de Dependências e Configuração de Variáveis de Ambiente:

1. Instalar e configurar as dependências da aplicação.
Configurar variáveis de ambiente para se adaptar ao ambiente de produção.
Deploy da Aplicação:

2. Subir o código da aplicação para as instâncias EC2.
Configurar servidores web ( ISS )

## Testes

ROTEIRO DE TESTES PARA REQUISITOS FUNCIONAIS.

A) Casos de Teste para ALERTAS

Descrição: Verificar se o requisito funcional "Alertas" fornece informações sobre a probabilidade de chuva.

Passos de Execução:

1 - Abra o aplicativo móvel.
2 - Navegue até a seção de Previsão.
3 - Digite o nome da cidade desejada.
4 - Aperte o botão Pesquisar.
5 - Vá até a aba Alertas.

Saídas Esperadas:

O aplicativo deve exibir o alerta climático para a cidade selecionada.
A informação sobre a probabilidade de chuva deve ser clara e precisa.

Critérios de Aceitação:

O alerta climático deve ser exibido em tempo real.
A probabilidade de chuva deve ser expressa em texto.
A informação de probabilidade de chuva deve ser atualizada regularmente.
As notificações de alerta devem ser entregues corretamente.

Cenários Adicionais:

Teste de Precisão: Comparar as informações de alerta climático com fontes confiáveis de dados meteorológicos para garantir precisão.

Este caso de teste abrange a funcionalidade crítica de fornecimento de alertas climáticos, com foco especial na precisão e na capacidade do aplicativo de informar sobre a probabilidade de chuva.


B) Caso de Teste para Previsão do Tempo:

Descrição: Verificar se o aplicativo móvel fornece uma previsão do tempo precisa e atualizada.

Passos de Execução:

1 - Abra o aplicativo móvel.
2 - Navegue até a seção de Previsão.
3 - Digite o nome da cidade desejada.
4 - Aperte o botão Pesquisar.

Saídas Esperadas:

O aplicativo deve exibir a previsão do tempo para a cidade selecionada e informações sobre possibilidade de chuva e condições de umidade e pressão.

Critérios de Aceitação:

A previsão do tempo deve abranger o período especificado.
A informação de previsão do tempo deve ser atualizada regularmente.



C) Caso de Teste para Feed de Notícias sobre o Tempo:

Descrição: Verificar se o aplicativo móvel fornece um feed de notícias sobre o tempo, mantendo os usuários informados sobre eventos climáticos relevantes.

Passos de Execução:

1 - Abra o aplicativo móvel.
2 - Navegue até a seção de FEED.
3 - Explore notícias sobre eventos climáticos recentes.
4 - Abra uma notícia específica para obter detalhes adicionais.

Saídas Esperadas:

O feed de notícias sobre o tempo deve conter informações relevantes e atualizadas.
Cada notícia deve incluir detalhes sobre o evento climático, possíveis impactos e precauções.

Critérios de Aceitação:

O feed de notícias deve ser atualizado regularmente.
As notícias devem ser apresentadas de forma clara e compreensível.
As notificações podem ser configuradas para alertar sobre notícias importantes.

Cenários Adicionais:

Teste de Navegação: Certificar-se de que os usuários podem navegar facilmente entre diferentes notícias e categorias no feed.


ROTEIRO PARA CASOS DE TESTE DE REQUISITOS NÃO-FUNCIONAIS

A) Caso de Teste para Usabilidade:

Descrição: Verificar se o software é fácil de usar e possui uma interface intuitiva.

Passos de Execução:

Abra o software.
Execute uma tarefa comum, como buscar informações ou realizar uma operação simples.

Saídas Esperadas:

O software deve apresentar uma interface clara e fácil de entender.
As funcionalidades básicas devem ser acessíveis com poucos cliques.
Os elementos da interface, como botões e menus, devem seguir uma lógica intuitiva.

Critérios de Aceitação:

A interface do software deve ser compreensível para usuários sem treinamento prévio.
Os elementos da interface devem ser consistentes em todo o software.


B) Caso de Teste para Tempo de Resposta:

Descrição: Verificar se o sistema retorna a resposta ao usuário em menos de 30 segundos.

Passos de Execução:

Execute uma operação que envolva processamento ou busca de dados.
Meça o tempo que o sistema leva para fornecer a resposta.

Saídas Esperadas:

O tempo de resposta do sistema deve ser inferior a 30 segundos.
O sistema deve exibir um indicador de progresso ou informação de que está processando durante operações mais demoradas.

Critérios de Aceitação:

O tempo de resposta deve ser consistente mesmo durante períodos de carga mais elevada.
Operações que normalmente levam menos de 5 segundos são consideradas altamente responsivas.


C) Caso de Teste para Disponibilidade do Sistema:

Descrição: Verificar se o sistema está disponível 99,97% do tempo.

Passos de Execução:

Monitore o tempo de disponibilidade do sistema durante um período específico.

Saídas Esperadas:

O sistema deve estar disponível 99,97% do tempo monitorado.
Qualquer tempo de inatividade ou falha deve ser documentado e investigado.

Critérios de Aceitação:

O sistema deve ser monitorado continuamente para garantir a conformidade com o requisito de disponibilidade.
Períodos de manutenção planejada não devem ser contabilizados como tempo de inatividade.



D) Caso de Teste para Interface de Usuário Rápida:

Descrição: Verificar se o sistema possui uma interface fácil de mexer e rápida para buscar informações.

Passos de Execução:

Realize uma busca de informações utilizando a interface do sistema.
Avalie a velocidade de carregamento dos resultados.

Saídas Esperadas:

A interface deve permitir buscas rápidas e eficientes.
Os resultados da busca devem ser carregados de forma ágil e responsiva.

Critérios de Aceitação:

O tempo de carregamento dos resultados de busca deve ser inferior a 5 segundos.
A interface deve fornecer opções de filtragem para facilitar a busca de informações específicas.


# Referências

Inclua todas as referências (livros, artigos, sites, etc) utilizados no desenvolvimento do trabalho.
