/** @format */

const commands = require("../commands");
const db = require("../database/database");
const config = require("../config");
let startTime = Date.now();

module.exports = async (client) => {
	commands.registerCategories(config.categories);
	commands.registerCommands();
	await db.check.createTables();
	client.user.setActivity(config.statusBOT);
	let time = Date.now() - startTime;
	console.log(`${client.user.username} est connecté sur ${client.guilds.cache.size} serveurs ! en ${time}ms`);
};
