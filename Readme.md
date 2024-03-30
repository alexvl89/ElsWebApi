## Проект Elasticsearch и C# net8

Для создания контейнера Elasticsearch и Kibana необходимо выполнить команду:
> docker-compose up -d

Т.к. есть блокировка по ip, то можно скачать нужные образы:

> docker pull elasticsearch:8.13.0

> docker pull kibana:8.13.0


После выполнения docker-compose можно проверить запущенные контейнеры
> docker ps

#### Пример выполненной команды с запущенными контейнерами:

> CONTAINER ID   IMAGE                  COMMAND                  CREATED         STATUS         PORTS                              NAMES
>
> 290cebaec562   kibana:8.13.0          "/bin/tini -- /usr/l…"   3 minutes ago   Up 3 minutes   0.0.0.0:5601->5601/tcp             kibana
>
> 5f73c5817240   elasticsearch:8.13.0   "/bin/tini -- /usr/l…"   3 minutes ago   Up 3 minutes   0.0.0.0:9200->9200/tcp, 9300/tcp   els


