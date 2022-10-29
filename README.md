# PackageCreation

Criação de pacote com publicação via GitHub Actions

## 1 Workflows

Foram criados dois workflows separados, sendo um para realização de build e teste da biblioteca, e outro para publicação da versão do pacote. O workflow de publicação é realizado apenas em caso de sucesso do workflow de build e teste.

## 2 Substituições necessárias para uso dos workflows em outro projeto

No *step* nomeado *Publish the Package* deve-se substituir:
1. Nome do diretório do projeto onde está a biblioteca.
2. Nome de usuário do repositório do GitHub.

## 3 Criação da secret para publicação do pacote

### 3.1 Gere um Personal Access Token (PAT)

- Acesse o [profile](https://github.com/settings/profile) do usuário no Github.
- No menu esquerdo, escolha a opção *Developer settings*.
- No menu esquerdo, escolha a opção *Personal access token*.
- Clique no botão *Generate new token*.
- Valide a requisição com sua senha.
- No formúlario, em note, informe o nome/descrição do token, a validade do token e marque as opções **write:packages** e **delete:packages** (algumas opções serão automaticamente marcadas).
- Clique no botão *Generate token*.
- Copie o token gerado pois o mesmo não será exibido novamente.

### 3.2 Inclua o PAT em *secrets* do repositório

- Acesse a aba *Settings* do repositório.
- No menu esquerdo, escolha a opção *Secrets->Actions*.
- Clique no botão *New repository secret*.
- Em *Name* informe a palavra *TOKEN* e em *Secret* cole o PAT gerado anteriormente.
- Clique no botão *Add secret*.
