// server.js
const jsonServer = require('json-server')
const glob = require('glob');
const fs = require('fs');
const jsonReader = require('read-data').json;
const jsonfile = require('jsonfile')

const server = jsonServer.create();
const router = jsonServer.router('db.json');
const middlewares = jsonServer.defaults();
server.use(middlewares);
server.use(router);
server.listen(25564, "10.5.35.35", () => {
	console.log('JSON Server is running');
});