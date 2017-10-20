describe('Truthyness', () => {

    it('Truthyness - 1', () => {
        var result;
        if(3){
            result = true;
        } else {
            result = false;
        }
        expect(result).toBe( _ );
    });

    it('Truthyness - 2', () => {
        var result;
        if(-1){
            result = true;
        } else {
            result = false;
        }
        expect(result).toBe( _ );
    });

    it('Truthyness - 3', () => {
        var result;
        if(0){
            result = true;
        } else {
            result = false;
        }
        expect(result).toBe( _ );
    });

    it('Truthyness - 4', () => {
        var result;
        if(null){
           result = true;
        } else {
            result = false;
        }
        expect(result).toBe( _ );
    });
	
	it('Truthyness - 5', () => {
        var result;
        if(undefined){
           result = true;
        } else {
            result = false;
        }
        expect(result).toBe( _ );
    });

	it('Truthyness - 6', () => {
        var result;
        if(new Boolean(false)){
           result = true;
        } else {
            result = false;
        }
        expect(result).toBe( _ );
    });

});