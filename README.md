# CarParkingApi
Application emulating car parking with API service

## REST API

### Cars
- List of cars (GET)

_GET /api/Cars_

- Car details (GET)

_GET /api/Cars/1_

- Remove car (DELETE)

_DELETE /api/Cars/1_

- Add car (POST)

_POST /api/Cars_


### Parking
- Number of free spaces (GET)

_GET /api/Parking/freespaces_

- Number of taken spaces (GET)

_GET /api/Parking/takenspaces_

- Total revenue (GET)

_GET /api/Parking/balance_


### Transactions
- Display Transactions.log (GET)

_GET /api/Transactions_

- Display transactions for the past minute (GET)

_GET /api/Transactions/pastminute_

- Display transactions for the past minute for a concrete car (GET)

_GET /api/Transactions/pastminute/1_

- Get income for the past minute (GET)

_GET /api/Transactions/income_

- Get income for the past minute for a concrete car (GET)

_GET /api/Transactions/income/1_

- replenish car balance (PUT)

_PUT /api/Transactions/replenish/1_

