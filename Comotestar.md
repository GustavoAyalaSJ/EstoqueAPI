===== Gerenciamento de Estoque em C# (Windows) =====

1. Baixe o Microsoft Visual Studio e selecione ASP.NET e desenvolvimento Web pelo Visual Studio Installer (para utilizar a API);

2. Após a instalação do ASP.NET e desenvolvimento Web com SDK do .NET 8.0 selecionado, baixe os arquivos do projeto;

3. Extraia os arquivos e abra um único arquivo .sln ou .slnx para abrir a pasta inteira do projeto;

4. Vá na aba "Ferramentas" em seguida para "Gerenciar de Pacotes no Nuget" e clique ou selecione o 'Console do Gerenciador de Pacotes';

5. Vá no console do Visual Studio e digite esta linha de comando:

Install-Package Swashbuckle.AspNetCore // Instalador do Swagger (Extensão);

Nota: O projeto só vai rodar, quando tanto a pasta do projeto e o Swagger tiver espaço suficiente no armazenamento (SSD) para rodar.

6.(opcional): Volte para aba "Ferramentas" e "Gerenciar de Pacotes No Nuget" e selecione "Gerenciar Pacotes Nuget para Solução" para certificar que
o Swagger foi instalado.

7. Clique em Run e geralmente o navegador ira abrir a aplicação sozinho, mas caso não abra, verifique a porta disponibilizada pelo CMD.

8. Após isso acesse qualquer navegador na sua máquina, cole o localhost e em seguida coloque "/swagger" após a númeração do PORT.

Divirta-se em mexer na tabela de estoque com o CRUD.
