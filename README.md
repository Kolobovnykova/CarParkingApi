# CarParkingApi
Application emulating car parking with API service

## REST API

### Cars
- Список всіх машин (GET)

_GET /api/Cars_

- Деталі по одній машині (GET)

_GET /api/Cars/1_

- Видалити машину (DELETE)

_DELETE /api/Cars/1_

- Додати машину (POST)

_POST /api/Cars_


### Parking
- Кількість вільних місць (GET)

_GET /api/Parking/freespaces_

- Кількість зайнятих місць (GET)

_GET /api/Parking/takenspaces_

- Загальний дохід (GET)

_GET /api/Parking/balance_


### Transactions
- Вивести Transactions.log (GET)

_GET /api/Transactions_

- Вивести транзакції за останню хвилину (GET)

_GET /api/Transactions/income_

- Вивести транзакції за останню хвилину по одній конкретній машині (GET)

_GET /api/Transactions/income/1_

- Поповнити баланс машини (PUT)

_PUT /api/Transactions/replenish/1_

