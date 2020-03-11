(() => {
	String.prototype.ensureStart = function(str) {
		if (!this.startsWith(str)) {
			return str + this;
		}
		return this + '';
	};

	String.prototype.ensureEnd = function(str) {
		if (!this.endsWith(str)) {
			return this + str;
		}
		return this + '';
	};

	String.prototype.isEmpty = function() {
		return this.length === 0;
	};

	String.prototype.truncate = function(n) {
		if (this.length <= n) {
			return this + '';
		} else if (n < 4) {
			return '.'.repeat(n);
		} else if (this.indexOf(' ') === -1) {
			return this.substring(0, this.length - 3) + '...';
		}

		//TODO Rewrite the last functionallity of truncate (length should be count without the dots);
		let result = this.substr(0, n - 3);
		let spaceIndex = result.lastIndexOf(' ');
		if (spaceIndex === 0) {
			result = result.substring(0, spaceIndex) + '...';
		} else {
			result = result + '...';
		}
		return result;
	};

	String.format = function f(str, ...params) {
		let replacements = {};
		for (let i = 0; i < params.length; i++) {
			replacements[`{${i}}`] = params[i];
		}

		let result = str.replace(/{\d{1,}}/g, function(all) {
			return replacements[all] || all;
		});

		return result;
	};
})();
