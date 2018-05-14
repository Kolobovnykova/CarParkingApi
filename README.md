# CarParkingApi
Application emulating car parking with API service

## REST API

### Cars
- Список всех машин (GET)

_GET /api/Cars_

- Детали по одной машине (GET)

_GET /api/Cars/1_

- Удалить машину (DELETE)

_DELETE /api/Cars/1_

- Добавить машину (POST)

_POST /api/Cars_


### Parking
- Количество свободных мест (GET)

_GET /api/Parking/freespaces_

- Количество занятых мест (GET)

_GET /api/Parking/takenspaces_

- Общий доход (GET)

_GET /api/Parking/balance_


### Transactions
- Вывести Transactions.log (GET)

_GET /api/Transactions_

- Вывести транзакции за последнюю минуту (GET)

_GET /api/Transactions/pastminute_

- Вывести транзакции за последнюю минуту по одной конкретной машине (GET)

_GET /api/Transactions/pastminute/1_

- Вывести доход за последнюю минуту (GET)

_GET /api/Transactions/income_

- Вывести доход за последнюю минуту по одной конкретной машине (GET)

_GET /api/Transactions/income/1_

- Пополнить баланс машини (PUT)

_PUT /api/Transactions/replenish/1_

