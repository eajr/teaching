let prompt = require('./helper');

prompt("What's your name? ")
  .then((name) => {
    console.log(`User's name is ${name}`);
  });