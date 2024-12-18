# Проект с использованием шаблона YaraOduvanchik.Service.Templates

## Описание

Этот репозиторий предоставляет шаблон для быстрого создания проектов ASP.NET Core Web API с заранее настроенными параметрами, такими как обработка ошибок, асинхронные методы и поддержка конфигурации.

## Установка шаблона

Для того чтобы использовать этот шаблон, его необходимо сначала установить. Вы можете сделать это, установив шаблон с GitHub или из локальной папки.

### Установка шаблона с GitHub

1. Убедитесь, что у вас настроены правильные параметры доступа для GitHub:

   Добавьте GitHub как источник NuGet:
   ```bash
   dotnet nuget add source "https://nuget.pkg.github.com/SachkovTech/index.json" --name github --username "YOUR_GITHUB_USERNAME" --password "YOUR_GITHUB_TOKEN"
   ```

2. Установите шаблон:
   ```bash
   dotnet new install "CleanArchitectureTemplate::1.0.0" --nuget-source "https://nuget.pkg.github.com/SachkovTech/index.json"
   ```

### Создание проекта
После того как шаблон установлен, вы можете использовать его для создания нового проекта.

1. Создайте новую папку для проекта:
   Создайте папку, в которой буде находится ваш проект, например:
    ```bash
   mkdir myFolder
   ```

   Затем перейдите в эту папку (Вместо "ProjectName" пишите название сервиса):
    ```bash
   cd ProjectName
   ```
   
   Если ваш шаблон имеет короткое имя webapiasync, выполните команду (Вместо "ProjectName" пишите название сервиса):
   ```bash
   dotnet new webapiasync -n ProjectName
   ```
   Для указания конкретной версии шаблона используйте:
   ```bash
   dotnet new webapiasync -v 1.0.
   ```
   
### Удаление шаблона
Если вы хотите удалить шаблон, выполните команду:
```bash
dotnet new uninstall webapiasync
```
Или, для удаления шаблона с определённой версией:
```bash
dotnet new uninstall webapiasync -v 1.0.0
```
