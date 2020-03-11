function solution() {
	class ProductBrand {
		constructor(manufacturer) {
			this.manufacturer = manufacturer;
		}
	}
	class Keyboard extends ProductBrand {
		constructor(manufacturer, responseTime) {
			super(manufacturer);
			this.responseTime = responseTime;
		}
	}
	class Monitor extends ProductBrand {
		constructor(manufacturer, width, height) {
			super(manufacturer);
			this.width = width;
			this.height = height;
		}
	}
	class Battery extends ProductBrand {
		constructor(manufacturer, expectedLife) {
			super(manufacturer);
			this.expectedLife = expectedLife;
		}
	}
	class Computer extends ProductBrand {
		constructor(manufacturer, processorSpeed, ram, hardDiskSpace) {
			if (new.target === Computer) {
				throw new Error('Cannot instaniate abstract class');
			}
			super(manufacturer);
			this.processorSpeed = processorSpeed;
			this.ram = ram;
			this.hardDiskSpace = hardDiskSpace;
		}
	}
	class Laptop extends Computer {
		constructor(manufacturer, processorSpeed, ram, hardDiskSpace, weight, color, battery) {
			super(manufacturer, processorSpeed, ram, hardDiskSpace);
			this.weight = weight;
			this.color = color;
			this.battery = battery;
		}
		get battery() {
			return this._battery;
		}
		set battery(value) {
			if (value instanceof Battery) {
				this._battery = value;
			} else {
				throw new TypeError('Different value than battery');
			}
		}
	}
	class Desktop extends Computer {
		constructor(manufacturer, processorSpeed, ram, hardDiskSpace, keyboard, monitor) {
			super(manufacturer, processorSpeed, ram, hardDiskSpace);
			this.keyboard = keyboard;
			this.monitor = monitor;
		}
		get keyboard() {
			return this._keyboard;
		}
		set keyboard(value) {
			if (value instanceof Keyboard) {
				this._keyboard = value;
			} else {
				throw new TypeError('Different value than keyboard');
			}
		}
		get monitor() {
			return this._monitor;
		}
		set monitor(value) {
			if (value instanceof Monitor) {
				this._monitor = value;
			} else {
				throw new TypeError('Different value than monitor');
			}
		}
	}

	return {
		ProductBrand,
		Battery,
		Keyboard,
		Monitor,
		Computer,
		Laptop,
		Desktop
	};
}

// let classes = solution();
// let Computer = classes.Computer;
// let Laptop = classes.Laptop;
// let Desktop = classes.Desktop;
// let Monitor = classes.Monitor;
// let Battery = classes.Battery;
// let Keyboard = classes.Keyboard;

// let keyboard = new Keyboard('Logitech', 70);
// let monitor = new Monitor('Benq', 28, 18);
// let desktop = new Desktop('JAR Computers', 3.3, 8, 1, keyboard, monitor);
// console.log(desktop.manufacturer); //.equal('JAR Computers', 'Expected manufacturer did not match.');
// console.log(desktop.processorSpeed); //.be.closeTo(3.3, 0.01, 'Expected processor speed did not match.');
// console.log(desktop.ram); //.equal(8, 'Expected RAM did not match.');
// console.log(desktop.hardDiskSpace); //.equal(1, 'Expected hard disk space did not match.');
// console.log(desktop.keyboard); //.equal(keyboard, 'Expected keyboard did not match.');
// console.log(desktop.monitor); //.equal(monitor, 'Expected monitor did not match.');
