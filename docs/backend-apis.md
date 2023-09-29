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
    ```
    {
  "message": "Cidade não encontrada, verifique os dados inseridos na requisição.",
  "error": "A cidade solicitada pelo usuário pode não estar no formato adequado (Ex: Ao invés de Rio de Janeiro: rio-de-janeiro, estar riodejaneiro)"
  }
  - Erro (500)
    ```
    {
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

[Instruções para implantar a aplicação distribuída em um ambiente de produção.]

1. Defina os requisitos de hardware e software necessários para implantar a aplicação em um ambiente de produção.
2. Escolha uma plataforma de hospedagem adequada, como um provedor de nuvem ou um servidor dedicado.
3. Configure o ambiente de implantação, incluindo a instalação de dependências e configuração de variáveis de ambiente.
4. Faça o deploy da aplicação no ambiente escolhido, seguindo as instruções específicas da plataforma de hospedagem.
5. Realize testes para garantir que a aplicação esteja funcionando corretamente no ambiente de produção.

## Testes

[Descreva a estratégia de teste, incluindo os tipos de teste a serem realizados (unitários, integração, carga, etc.) e as ferramentas a serem utilizadas.]

1. Crie casos de teste para cobrir todos os requisitos funcionais e não funcionais da aplicação.
2. Implemente testes unitários para testar unidades individuais de código, como funções e classes.
3. Realize testes de integração para verificar a interação correta entre os componentes da aplicação.
4. Execute testes de carga para avaliar o desempenho da aplicação sob carga significativa.
5. Utilize ferramentas de teste adequadas, como frameworks de teste e ferramentas de automação de teste, para agilizar o processo de teste.

# Referências

Microsoft. Documentação oficial do .NET Core. Disponível em: https://docs.microsoft.com/pt-br/dotnet/. Acesso em: 29/09/2023.
OWASP. OWASP Top Ten Project. Disponível em: https://owasp.org/www-project-top-ten/. Acesso em: 29/09/2023.
Amazon Web Services (AWS). Disponível em: https://aws.amazon.com/. Acesso em: 29/09/2023.
