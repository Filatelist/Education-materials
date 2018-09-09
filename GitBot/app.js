const TelegramBot = require('node-telegram-bot-api');
const token = '652865552:AAHFE9Slm1mQw0kqV21ivMQjdAt-xKlb0i4';
const bot = new TelegramBot(token, {polling: true});

bot.onText(/\/echo (.+)/, (msg, match) => {

  const chatId = msg.chat.id;
  const resp = match[1];
  bot.sendMessage(chatId, resp);
});

bot.on('message', (msg) => {
  const chatId = msg.chat.id;
  bot.sendMessage(chatId, 'Recive');
});
