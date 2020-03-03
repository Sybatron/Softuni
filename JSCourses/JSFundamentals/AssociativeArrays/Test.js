const mapObj = {
    clear() {
        for (const key in mapObj) {
            if (mapObj[key] != undefined) {
                delete key;
            }
        }
    },

    length() {
        let count = 0;
        for (const key in mapObj) {
            if (mapObj[key]) {
                count++;
            }
        }
        return count;
    }
};


mapObj['sdfsd'] = 'sdfsdf';
mapObj['mbnm'] = 'sdfsdf';
mapObj['bnmbn'] = 'sdfsdf';
mapObj['bnmb'] = 'sdfsdf';
mapObj['hgf'] = 'sdfsdf';

console.log(mapObj.length());
mapObj.clear();
console.log(mapObj.length());