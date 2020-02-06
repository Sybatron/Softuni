function serializeString(str) {
    let serializedString = {};

    for (let i = 0; i < str.length; i++) {
        if (serializedString[str[i]] === undefined) {
            serializedString[str[i]] = [];
        }

        serializedString[str[i]].push(i);
    }

    for (let prop in serializedString) {
        console.log(`${prop}:${serializedString[prop].join('/')}`);
    }
}

serializeString('ababa');