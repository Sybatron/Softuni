function registrationValidator(input) {
    let length = parseInt(input.shift());
    let count = 0;
    let pattern = /U\$(?<username>[A-Z][a-z]{2,})U\$P@\$(?<password>[A-Za-z]{5,}\d{1,})P@\$/;

    for (let i = 0; i < length; i++) {
        let registration = input[i];

        let match = pattern.exec(registration);
        if (match !== null) {
            count++;

            console.log('Registration was successful');
            console.log(`Username: ${match.groups.username}, Password: ${match.groups.password}`);
        } else {
            console.log('Invalid username or password');
        }
    }

    console.log(`Successful registrations: ${count}`);
}

registrationValidator([
    3,
    'U$MichaelU$P@$asdqwe123P@$',
    'U$NameU$P@$PasswordP@$',
    'U$UserU$P@$ad2P@$'
])