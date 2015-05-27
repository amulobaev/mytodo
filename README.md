# Тестовое задание #

### 1. Постановка задачи ###
Необходимо разработать WEB-приложение “ToDo” для управление задачами пользователя.
### 2. Требования ###
### 2.1. Функциональные требования. ###
1. Создание, изменение и удаление задач пользователем.
2. Изменение статуса задачи: новая, выполняется, выполнена, отклонена.
3. Уведомление пользователя о просроченных задачах.
4. Пользователи в системе должны регистрироваться при входе в приложение посредством ввода данных.
5. В результате регистрации пользователя на его электронный адрес должно приходить уведомление о регистрации.
6. Каждый пользователь управляет только своими задачами.
7. В случае просрочки срока выполнения задачи пользователь должен получать уведомление об этом по электронной почте.

### 2.2. Технические требования. ###
1. Необходимо использовать следующие технологии:
а) ASP.NET MVC 5, WebApi 2, ASP.NET Identity 2, Entity Framework 6;
б) MS SQL Express 2012/2014 или LocalDb;
в) Bootstrap 3 (LESS-исходники) или аналог для UI;
г) AngularJS или KnockoutJS (или аналогичный клиентский фреймворк).
2. Приложение должно быть доступно через сеть Интернет.
3. Вход и регистрация пользователя по логину и паролю.
4. Объектная модель данных приложения должна включать следующие объекты:
а) пользователь: имя, логин, e-mail
б) задача: наименование, текст, статус (новая, выполняется, выполнена, отменена), срок создания, срок выполнения.
5. Технические параметры почтовых уведомлений должны задаваться в web.config.

### 2.3. Требования к пользовательскому интерфейсу ###
Пользовательский интерфейс приложения должен быть доступен через веб-обозреватель и удовлетворять следующим требованиям.
1. При входе в приложение пользователю отображается форма ввода логина и пароля и ссылка на форму регистрации нового пользователя.
2. Для успешно аутентифицированных пользователей должен отображаться список задач, содержащий наименование, срок исполнения и статус каждой задачи.
3. Список задач должен иметь сортировку по всем полям списка.
4. Список задач должен иметь фильтры по дате и статусу.
5. По нажатию на элемент (строку) списка должно открываться модальное диалоговое окно с формой редактирования задачи.
6. Должна быть реализована кнопка создания новой задачи, открывающая форму ввода параметров задачи.
7. Должна быть предусмотрена кнопка удаления задач.

Необходимо предоставить проект для Visual Studio 2012/2013 в виде набора файлов или репозитории Mercurial.