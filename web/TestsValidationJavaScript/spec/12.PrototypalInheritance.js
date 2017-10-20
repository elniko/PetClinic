describe('Prototype inheritance', () => {

    function Mammal(name) {
        this.name = name;
    }

    Mammal.prototype = {
        sayHi() {
            return "Hello, my name is " + this.name;
        }
    };

    it("Prototype inheritance - 1", () => {
        var eric = new Mammal("Eric");
        expect(eric.sayHi()).toBe( _ );
    });

    Mammal.prototype.favouriteSaying = () => {
        return this.name + "'s favourite saying is " + this.sayHi();
    };

    it("Prototype inheritance - 2", () => {
        var bobby = new Mammal("Bobby");
        expect(eric.favouriteSaying()).toBe( _ );
        expect(bobby.favouriteSaying()).toBe( _ );
    });

    it("Prototype inheritance - 3", () => {
        var paul = new Mammal("Paul");
        Object.defineProperty(Mammal.prototype, 'numberOfLettersInName', {
            get: function () {
                return this.name.length;
            }
        });
        expect(paul.numberOfLettersInName).toBe( _ );
    });

    function extend(child, supertype){
        child.prototype = Object.create(supertype.prototype);
    }

    function Bat(name, wingspan) {
        Mammal.call(this, name);
        this.wingspan = wingspan;
    }

    extend(Bat, Mammal);

    it("Prototype inheritance - 4", () => {
        var lenny = new Bat("Lenny", "1.5m");
        expect(lenny.sayHi()).toBe( _ );
        expect(lenny.wingspan).toBe( _ );
    });

});