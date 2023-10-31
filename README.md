# Quick Order - Tech Challenge FIAP

Projeto do Tech Challenge da FIAP - Fase 1

**INTEGRANTES DO GRUPO 36**

* Matheus Augusto Silva dos Santos
matheus.santos8192@outlook.com

* Moisés Barboza de Figueiredo Junior
moises.figueiredo@gmail.com

* Keilla Cristina Martins Conforto
kcrismartins@gmail.com

* Gabriela da Silva Lopes
gabrieladslopes@gmail.com

* Francisco Tadeu da Silva e Souza
fsouza.thadeu@gmail.com

<br />

## Começando

As instruções abaixo ajudarão a baixar e executar o projeto em máquina local.

### Pré-Requisitos

Antes de executar este projeto, os seguintes itens deverão estar instalados no computador:

* Docker
* Visual Studio 2022 ou Visual Studio Code

### Instalação pelo Visual Studio 2022

Passo a passo:

* Baixar o projeto através do repositório do **GitHub**
* Abrir o projeto no **Visual Studio 2022**
* Localizar o arquivo **docker-compose** no Solution Explorer:
<br />

![image](https://github.com/TechChallenge-4SOAT-G36/QuickOrder/assets/19378661/a4f481ce-4f13-4980-913d-f6751aec050a)

<br />

* Clicar nele com o botão direito e selecionar **Set as Startup Projetct**:

<br />

![image](https://github.com/TechChallenge-4SOAT-G36/QuickOrder/assets/19378661/f16770a5-ed9e-47df-ad84-b8363ca79832)

<br />

* Clicar na opção **Docker Compose** da barra de ferramentas padrão:

<br />

![image](https://github.com/TechChallenge-4SOAT-G36/QuickOrder/assets/19378661/495ec4ef-9b0f-4037-8f0b-7390c485a616)

<br />

* O Visual Studio criará os containers e exibirá a tela do Swagger da API:

<br />

![image](https://github.com/TechChallenge-4SOAT-G36/QuickOrder/assets/19378661/c6b1d930-5ea2-459d-a116-a9f960c72c7e)

<br />

![image](https://github.com/TechChallenge-4SOAT-G36/QuickOrder/assets/19378661/4bac9341-7130-4445-b675-88adfa3ccb53)

<br />

### Instalação pelo Visual Studio Code

Passo a passo:

* Baixar o projeto através do repositório do **GitHub**
* Abrir o projeto no **Visual Studio Code**
* Abrir alguma interface de linha de comando como, por exemplo, o **PowerShell** e navegar até a pasta **src** do Projeto:

<br />

![image](https://github.com/TechChallenge-4SOAT-G36/QuickOrder/assets/19378661/d1ab97a6-9c8f-407f-bc98-e0cdb08f860d)

<br />

* Executar o comando `docker-compose up -d`
* Os containeres são levantados conforme imagem abaixo e poderão ser listados através do comando `docker ps`

<br />

![image](https://github.com/TechChallenge-4SOAT-G36/QuickOrder/assets/19378661/046561e8-9527-4e97-9882-1da1b04a9041)



<br />

* Abrir algum browser e informar o seguinte endereço: **http://localhost:8090/swagger/index.html**
* O resultado deverá ser conforme abaixo:

<br />

![image](https://github.com/TechChallenge-4SOAT-G36/QuickOrder/assets/19378661/c1150eb1-a25a-4ee2-aeb8-c0c03ede965f)
