# CarParkingApi
Application emulating car parking with API service

## REST API

### Cars
- Список всіх машин (GET)

_GET /api/Cars_

- Деталі по одній машині (GET)

GET /api/Cars/1

- Видалити машину (DELETE)

DELETE /api/Cars/1

- Додати машину (POST)

POST /api/Cars


### Parking
- Кількість вільних місць (GET)

GET /api/Parking/freespaces

- Кількість зайнятих місць (GET)

GET /api/Parking/takenspaces

- Загальний дохід (GET)

GET /api/Parking/balance


### Transactions
- Вивести Transactions.log (GET)

GET /api/Transactions

- Вивести транзакції за останню хвилину (GET)

GET /api/Transactions/income

- Вивести транзакції за останню хвилину по одній конкретній машині (GET)

GET /api/Transactions/income/1

- Поповнити баланс машини (PUT)

PUT /api/Transactions/replenish/1

