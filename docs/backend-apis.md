# APIs e Web Services

API foi criada para fornecer informações climáticas para a aplicação web e aplicação móvel da PreviAqua, com foco em alertas de inundações.

## Objetivos da API

O objetivo é fornecer às aplicações web e móvel o acesso ao cadastro de usuários, autenticação de usuário, alerta de eventos climáticos e consulta de dados climáticos. A API não será disponibilizada para consulta externa.

## Arquitetura

A API visa fornecer informações climáticas tendo como ponto principal o alerta de inundações. As aplicações web e aplicações móveis farão as solicitação para uma API Gateway usando HTTPS. Em seguida a API Gateway fará as solicitações via HTTP para as APIs dos outros serviços: autenticação de usuário, cadastro de usuário, alerta de eventos climáticos, consulta de dados climáticos (que por sua vez consulta a API externa do INMET).

## Modelagem da Aplicação
A aplicação PreviAqua tem uma estrutura de dados que envolve principalmente informações climáticas de diferentes cidades.

**API Consulta de Dados Climáticos**
- Entidades Principais:
1. Cidade: Representa informações sobre uma cidade específica, incluindo nome, coordenadas geográficas (latitude e longitude) e informações climáticas associadas.
2. Usuário: Armazena dados de usuários da aplicação, incluindo informações de autenticação e permissões.
3. Estação Meteorológica: Representa uma estação meteorológica, com informações como código de estação, localização (latitude e longitude), e dados específicos da estação, como temperatura, umidade, pressão atmosférica, etc.

## Fluxo de Dados

**API Consulta de Dados Climáticos**
1. A API Alerta de eventos climáticos envia via HTTP a solicitação usando o método GET /api/Previsoes/{cidade} em que cidade corresponde ao nome da cidade em que os espaços são separados por hífen (Ex: Rio de Janeiro: rio-de-janeiro).
2. A API de Consulta de Dados climáticos recebe a requisição, trata o nome da cidade removendo os hífens.
3. A partir do nome da cidade, pesquisa na lista Estacoes.json pelo atributo DC_NOME correspondente à cidade solicitada.
4. A partir da identificação do elemento desejado, procura pelo atributo CD_WSI.
5. Faz um tratamento do atributo CD_WSI, coletando os valores numéricos do oitavo ao décimo quarto, que correspondem ao geocode da estação.
6. Com o geocode, monta uma solicitação para a API do INMET solicitando os dados climáticos daquela localização.
7. Retorna para o usuário a resposta, se sucesso, retorna os parâmetros da solicitação que incluem informações sobre precipitação, vento, umidade, dentre outros. 

## Requisitos Funcionais

1. A aplicação deve permitir aos usuários consultar informações climáticas, incluindo alertas de inundações, para uma cidade específica.
2. Os usuários devem ser capazes de fornecer o nome da cidade como entrada para a consulta de informações climáticas.
3. A API deve autenticar os usuários antes de permitir o acesso às informações climáticas.
4. A API deve fornecer dados detalhados sobre o clima da cidade, incluindo pressão atmosférica, temperatura, umidade, direção do vento e outros parâmetros relacionados ao clima.

## Requisitos Não Funcionais

1. Segurança: A API deve implementar medidas de segurança, como autenticação, autorização e validação de entrada, para proteger os dados e os usuários.
2. Desempenho: A API deve ser capaz de lidar com um grande volume de solicitações simultâneas e responder de forma eficiente.
3. Disponibilidade: A API deve ser altamente disponível, minimizando o tempo de inatividade e garantindo que os usuários possam acessar as informações climáticas a qualquer momento.
4. Escalabilidade: A arquitetura da API deve permitir escalabilidade fácil para lidar com um aumento no número de usuários e solicitações.
5. Monitoramento de Segurança: Deve ser implementado um sistema de monitoramento de segurança para detectar atividades suspeitas em tempo real.
6. Testes: A aplicação deve ser extensivamente testada, incluindo testes unitários, de integração, de carga e de segurança, para garantir sua confiabilidade e desempenho.
7. Documentação: A API deve ser bem documentada, incluindo detalhes sobre como usar os endpoints, parâmetros aceitáveis e exemplos de solicitações e respostas.

## Tecnologias Utilizadas
- ASP.NET Core
- Entity Framework
- Visual Studio

## API Endpoints

**<<< QUANDO TODOS TERMINAREM, APAGAR O EXEMPLO DAQUI >>>**
[Liste os principais endpoints da API, incluindo as operações disponíveis, os parâmetros esperados e as respostas retornadas.]

### Endpoint 1
- Método: GET
- URL: /endpoint1
- Parâmetros:
  - param1: [descrição]
- Resposta:
  - Sucesso (200 OK)
    ```
    {
      "message": "Success",
      "data": {
        ...
      }
    }
    ```
  - Erro (4XX, 5XX)
    ```
    {
      "message": "Error",
      "error": {
        ...
      }
    }
    ```
**<<< ATÉ AQUI >>>**

### API Consulta de Dados Climáticos
- Método: GET
- URL: /api/Previsao/{cidade}
- Parâmetros:
  - cidade (string): O nome da cidade para consultar a previsão do tempo.
- Resposta:
  - Sucesso (200 OK)
    ```
    {
    "message": "Success",
    "data": {
      "DC_NOME": "Nome da Cidade",
      "PRE_INS": "Pressão atmosférica ao nível da estação, horária(mB)",
      "TEM_SEN": "Sensação térmica",
      "VL_LATITUDE": "Latitude",
      "PRE_MAX": "Pressão atmosférica máxima na hora anterior(mB)",
      "UF": "Unidade Federativa",
      "RAD_GLO": "Radiação global(W/m2)",
      "PTO_INS": "Temperatura do ponto de orvalho(°C)",
      "TEM_MIN": "Temperatura mínima na hora anterior(°C)",
      "VL_LONGITUDE": "Longitude",
      "UMD_MIN": "Umidade relativa mínima na hora anterior(%)",
      "PTO_MAX": "Temperatura orvalho máxima na hora anterior(°C)",
      "VEN_DIR": "Vento, direção horária(°gr)",
      "DT_MEDICAO": "Data da medição",
      "CHUVA": "Precipitação total, horário(mm)",
      "PRE_MIN": "Pressão atmosférica mínima na hora anterior(mB)",
      "UMD_MAX": "Umidade relativa máxima na hora anterior(%)",
      "VEN_VEL": "Vento, velocidade horária(m/s)",
      "PTO_MIN": "Temperatura orvalho mínima na hora anterior(°C)",
      "TEM_MAX": "Temperatura máxima na hora anterior(°C)",
      "TEN_BAT": "Tensão da bateria da estação(V)",
      "VEN_RAJ": "Vento, rajada máxima",
      "TEM_CPU": "Temperatura do processador da estação(°C)",
      "TEM_INS": "Temperatura do ar - bulbo seco, horária (°C)",
      "UMD_INS": "Umidade relativa do ar, horária(%)",
      "CD_ESTACAO": "Código da estação",
      "HR_MEDICAO": "Hora da medição"
    }
    }
    ```
  - Erro (404)
    ```{
  "message": "Cidade não encontrada, verifique os dados inseridos na requisição.",
  "error": "A cidade solicitada pelo usuário pode não estar no formato adequado (Ex: Ao invés de Rio de Janeiro: rio-de-janeiro, estar riodejaneiro)"
  }
  - Erro (500)
    ```{
  "message": "Erro interno do servidor: Nenhum resultado encontrado.",
  "error": "Caso aconteça, durante o processamento, algum erro não relacionado ao usuário."
  }
    ```

## Considerações de Segurança

A segurança é uma consideração crítica para garantir a integridade e confiabilidade da API. Abaixo estão algumas considerações de segurança importantes:

1. Autenticação e Autorização: Implemente um sistema robusto de autenticação e autorização para garantir que apenas usuários autorizados tenham acesso à API. Utilize tokens de autenticação, como OAuth2, para controlar o acesso aos endpoints.
2. Validação de Dados de Entrada: Valide cuidadosamente todos os dados de entrada fornecidos pelos clientes para evitar ataques de injeção de código, como SQL Injection ou Cross-Site Scripting (XSS). Use validação de entrada e escape de saída para sanitizar os dados.
3. Proteção contra Ataques de DDoS: Implemente medidas de proteção contra ataques de negação de serviço distribuído (DDoS) para garantir que a API possa lidar com um grande volume de solicitações sem comprometer sua disponibilidade.
4. Segurança em Camadas: Considere a implementação de segurança em várias camadas, incluindo firewalls de rede, firewalls de aplicativos, monitoramento de segurança e controle de acesso baseado em função.
5. Logs e Auditoria: Mantenha registros detalhados de todas as atividades da API, incluindo solicitações, respostas e eventos de segurança. Isso ajudará na detecção e resposta a ameaças em tempo real.
6. Atualizações e Patches: Mantenha a infraestrutura e os sistemas de software atualizados com as últimas correções de segurança. Isso inclui atualizações regulares do sistema operacional, servidores web e bibliotecas utilizadas.

## Implantação

## 1- Preparação do Aplicativo

Primeiro, garantiremos que nosso aplicativo esteja completamente desenvolvido e funcione localmente. Criaremos um arquivo Dockerfile no diretório do projeto que incluirá todas as instruções necessárias para empacotar o aplicativo em um contêiner Docker.

## 2- Construção da Imagem Docker

Usaremos o Docker localmente para construir nossa imagem Docker a partir do Dockerfile. Certificaremos de que a imagem inclua todas as dependências necessárias para nosso aplicativo. Isso é crucial para garantir que nosso aplicativo funcione consistentemente em um ambiente de contêiner.

## 3- Implantação no Amazon ECR (Elastic Container Registry)

Vamos criar um repositório no Amazon ECR para armazenar nossa imagem Docker. Em seguida, usaremos a AWS CLI para autenticar e fazer o push da imagem Docker para esse repositório. Isso nos permitirá centralizar o armazenamento de nossas imagens Docker e garantir que elas estejam disponíveis para implantação no ECS.

## 4- Configuração do Cluster ECS

Criaremos um cluster no Amazon ECS onde implantaremos e executaremos nosso aplicativo. Também definiremos uma definição de tarefa ECS que descreverá como nosso aplicativo será executado em contêineres. Isso incluirá detalhes como a imagem Docker a ser usada e as portas de exposição.

## 5- Criando uma Instância EC2

Para executar nossos contêineres, criaremos uma instância EC2 na AWS e a configuraremos com o agente ECS. Garantiremos que essa instância EC2 faça parte do cluster ECS que criamos anteriormente. Essa instância será responsável por executar nossos contêineres conforme necessário.

## 6- Criando um Serviço ECS

Criaremos um serviço ECS que usará a definição de tarefa que criamos. Isso garantirá que nosso aplicativo seja executado de forma escalável e gerenciada automaticamente pelo ECS. Podemos especificar o número desejado de tarefas e as políticas de escalabilidade conforme necessário.

## 7- Acessando o Aplicativo

Após uma implantação bem-sucedida no ECS, poderemos acessar nosso aplicativo usando o endereço IP público ou DNS da instância EC2 na qual nossos contêineres estão sendo executados. Certificaremos de que a infraestrutura de rede esteja configurada corretamente para permitir o acesso ao nosso aplicativo.

## Testes

## 1 - Preparação dos Casos de Teste

1.1. Identificaremos e documentaremos todos os requisitos funcionais e não funcionais da aplicação que devem ser testados.

1.2. Com base nos requisitos identificados, criaremos casos de teste que cobrirão todos os cenários possíveis, incluindo casos de sucesso e casos de erro.

## 2 - Implementação de Testes Unitários

2.1. Para cada unidade de código (funções, classes, módulos), implementaremos testes unitários usando uma estrutura de teste apropriada para C#, como o MSTest ou NUnit.

2.2. Certificaremos de que os testes unitários validarão a funcionalidade correta das unidades individuais de código em C#.

## 3 - Realização de Testes de Integração

3.1. Configuraremos e executaremos testes de integração para verificar se os diferentes componentes da aplicação interagirão corretamente.

3.2. Certificaremos de que os testes de integração cubram a comunicação entre os contêineres Docker, o funcionamento correto do ECS e a integração com outros serviços da AWS, como por exemplo AWS CodePiPeline e seus serviços de esteira CI/CD

## 4 - Execução de Testes de Carga

4.1. Criaremos cenários de teste de carga que simularão diferentes níveis de tráfego, desde níveis normais até picos de tráfego.

4.2. Avaliaremos a capacidade de escalabilidade do ECS durante os testes de carga.

## 5 - Utilização de Ferramentas de Teste Adequadas

5.1. Escolheremos as ferramentas de teste apropriadas para cada tipo de teste (por exemplo, frameworks de teste para testes unitários e ferramentas de teste de carga para testes de carga).

5.2. Configuraremos e automatizaremos os testes sempre que possível para garantir que eles possam ser executados de forma consistente e repetível.

## 6 - Execução dos Testes

6.1. Antes de iniciarmos os testes, certificaremos de que o ambiente de implantação estará configurado e pronto para receber os contêineres Docker. ( VPC, ACL, SUBNET, ROUTE TABLE E SECURITY GROUPS )

6.2. Executaremos os testes em um ambiente controlado, como um ambiente de teste AWS separado ( Região diferente da implantação oficial ) , para evitar impactos no ambiente de produção.

## 7 - Análise dos Resultados dos Testes

7.1. Analisaremos os resultados dos testes para identificar quaisquer falhas ou problemas encontrados.

7.2. Documentaremos todas as falhas, incluindo detalhes sobre como reproduzi-las e as condições em que ocorreram.

## 8 - Correção e Reteste

8.1. Corrigiremos quaisquer problemas identificados nos testes e verificaremos se as correções foram bem-sucedidas.

8.2. Realizaremos testes adicionais para confirmar que as correções não causaram regressões em outras partes da aplicação.

## 9 - Documentação e Relatório

9.1. Documentaremos os resultados dos testes, incluindo casos de teste executados, resultados de testes, problemas encontrados e ações corretivas tomadas.

9.2. Prepararemos um relatório de teste que incluirá informações sobre a cobertura de teste, desempenho e conformidade com os requisitos.

# Referências

Microsoft. Documentação oficial do .NET Core. Disponível em: https://docs.microsoft.com/pt-br/dotnet/. Acesso em: 29/09/2023.
OWASP. OWASP Top Ten Project. Disponível em: https://owasp.org/www-project-top-ten/. Acesso em: 29/09/2023.
Amazon Web Services (AWS). Disponível em: https://aws.amazon.com/. Acesso em: 29/09/2023.
