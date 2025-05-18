# LR4-Proxy
# Simple Proxy Server

Реализация прокси-сервера.

  
## Особенности

  
- Работает как промежуточный сервер между клиентами и целевыми веб-серверами
  
- Запускается на указанном IP-адресе (по умолчанию 127.0.0.2) и порту (по умолчанию 8080)
  
- Поддерживает базовый прокси-функционал для HTTP-запросов
  

  
## Как использовать

  
1. Скомпилируйте проект:
   ```
   dotnet build
   ```

  
2. Запустите приложение:
   ```
   dotnet run
   ```

     
   Или укажите другой порт:
   ```
   dotnet run -- 9090
   ```
![image](https://github.com/user-attachments/assets/b80e891b-1479-4c35-8f2c-d110ee926964)

3. Настройте ваш браузер или приложение на использование прокси 127.0.0.2:8080 (или на указанный вами порт)
   
![image](https://github.com/user-attachments/assets/c15512b5-d19f-462c-92b0-977f003f6f93)

5. Для остановки сервера нажмите Ctrl+C в консоли

   ![image](https://github.com/user-attachments/assets/4e8b17d7-a3c2-44ed-8754-ba7c183e6766)
## РЕЗУЛЬТАТ РАБОТЫ В БРАУЗЕРЕ FIREFOX
![image](https://github.com/user-attachments/assets/b6c6d14c-9bc5-4a21-9fe1-db1805d684a4)
![image](https://github.com/user-attachments/assets/c4aae9cf-60d3-4d95-9435-bb959de5e0c0)


   
