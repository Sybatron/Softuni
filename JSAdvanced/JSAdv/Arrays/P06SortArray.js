function sortArray(arr) {
    function sortF(text1, text2) {
        if (text1.length > text2.length) {
            return 1;
        } else if (text1.length < text2.length) {
            return -1;
        }

        return text1.localeCompare(text2);
    }

    arr = arr.sort(sortF);
    console.log(arr.join('\n'));
}

sortArray(['alpha',
    'beta',
    'gamma'
]);