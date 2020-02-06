function inboxManager(commands) {
    class User {
        sentEmails = [];
    }
    let usersManager = {};

    function add(username) {
        if (usersManager[username] === undefined) {
            usersManager[username] = new User();
        } else {
            console.log(`${username} is already registered`);
        }
    }

    function send(username, email) {
        usersManager[username]
            .sentEmails
            .push(email);
    }

    function deleteUser(username) {
        if (usersManager[username] !== undefined) {
            delete usersManager[username];
        } else {
            console.log(`${username} not found!`);
        }
    }

    for (let i = 0; i < commands.length - 1; i++) {
        const element = commands[i].split('->');
        if (element[0] === 'Add') {
            let username = element[1];
            add(username);
        } else if (element[0] === 'Send') {
            let username = element[1];
            let email = element[2];
            send(username, email);
        } else if (element[0] === 'Delete') {
            let username = element[1];
            deleteUser(username);
        }
    }

    let propsCount = Object.keys(usersManager).length;
    console.log(`Users count: ${propsCount}`);

    function sortF(ob1, ob2) {
        if (ob1[1].sentEmails.length > ob2[1].sentEmails.length) {
            return -1;
        } else if (ob1[1].sentEmails.length < ob2[1].sentEmails.length) {
            return 1;
        }

        // Else go to the 2nd item
        return ob1[0].localeCompare(ob2[0]);
    }

    let sortedProps = Object.entries(usersManager);
    sortedProps = sortedProps.sort(sortF);

    for (const key of sortedProps) {
        console.log(key[0]);
        for (const email of usersManager[key[0]].sentEmails) {
            console.log(` - ${email}`);
        }
    }
}

inboxManager([
    'Add->Mike',
    'Add->George',
    'Send->George->Hello World',
    'Send->George->Some random test mail',
    'Send->Mike->Hello, do you want to meet up tomorrow?',
    'Send->George->It would be a pleasure',
    'Send->Mike->Another random test mail',
    'Statistics'
]);