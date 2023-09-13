# Prueba técnica AFP Crecer
Autor: Erick Marroquín


## Crear Empresa

### Crear Empresa Request

```js
POST /api/enterprises
```

```json
{
	"enterprise": "Pepsi",
	"companyName": "Pepsico Iberia Servicios Centrales, S.L",
	"registrationDate": "2022-04-08T08:00:00"
}
```

### Crear Empresa Response

```js
201 Created
```

```js
Location: {{host}}/api/enterprises/{{id}}
```

```js
{
	"id": "00000000-0000-0000-0000-000000000000",
	"enterprise": "Pepsi",
	"companyName": "Pepsico Iberia Servicios Centrales, S.L",
	"registrationDate": "2022-04-08T08:00:00",
	"createdAt": "2023-09-13T08:00:00",
	"updatedAt": "2023-09-13T08:00:00"
}
```

## Consultar Empresa

### Consultar Empresa Request

```js
GET /api/enterprises/{{id}}
```

### Consultar Empresa Response

```js
200 Ok
```

```json
{
	"id": "00000000-0000-0000-0000-000000000000",
	"enterprise": "Pepsi",
	"companyName": "Pepsico Iberia Servicios Centrales, S.L",
	"registrationDate": "2022-04-08T08:00:00",
	"createdAt": "2023-09-13T08:00:00",
	"updatedAt": "2023-09-13T08:00:00"
},
```

## Crear Departamento

### Crear Departamento Request

```js
POST /api/departments
```

```json
{
	"department": "Legal Department",
	"employees": 4,
	"organizationLevel": 2,
	"enterprise": "00000000-0000-0000-0000-000000000000"
}
```

### Crear Departamento Response

```js
201 Created
```

```js
Location: {{host}}/api/departments/{{id}}
```

```json
{
	"id": "00000000-0000-0000-0000-000000000000",
	"department": "Legal Department",
	"employees": 4,
	"organizationLevel": 2,
	"enterprise": "00000000-0000-0000-0000-000000000000",
	"createdAt": "2023-09-13T08:00:00",
	"updatedAt": "2023-09-13T08:00:00"
}
```


## Consultar Departamentos por Empresa

### Departamentos por empresa Request

```js
GET /api/enterprises/{{id}}/departments
```

### Departamentos por empresa Response

```js
200 Ok
```

```json
[
	{
		"id": "00000000-0000-0000-0000-000000000000",
		"department": "Legal Department",
		"employees": 4,
		"organizationLevel": 2,
		"enterprise": "00000000-0000-0000-0000-000000000000",
		"createdAt": "2023-09-13T08:00:00",
		"updatedAt": "2023-09-13T08:00:00"
	},
	{
		"id": "00000000-0000-0000-0000-000000000000",
		"department": "IT Department",
		"employees": 4,
		"organizationLevel": 2,
		"enterprise": "00000000-0000-0000-0000-000000000000",
		"createdAt": "2023-09-13T08:00:00",
		"updatedAt": "2023-09-13T08:00:00"
	}
]
```
