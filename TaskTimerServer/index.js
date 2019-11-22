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



glob(__dirname + '/userData/*.json', {}, (err, files)=>{
	let userData = {
		"tasks": []
	};
	files.forEach(function(file, fIndex){ //for each file in the folder
		console.log("Found file: " + file);
		let json = jsonReader.sync(file, 'utf8');
		json.forEach(function(task, tIndex){ //for each task in the JSON
			let id = userData["tasks"].length;
			task["id"] = id;
			task["participantID"] = file.substring(file.lastIndexOf("/") + 1).replace('.json', '');
			userData["tasks"].push(task);		
		});
	});
	jsonfile.writeFileSync('tempUserData.json', userData);
	startExternalTaskServer();
});



function startExternalTaskServer(){
	const server = jsonServer.create();
	const router = jsonServer.router('tempUserData.json');
	const middlewares = jsonServer.defaults();
	server.use(middlewares);
	server.use(router);
	server.listen(25562, "10.5.35.35", () => {
		console.log('External task response server is running');
	});
}