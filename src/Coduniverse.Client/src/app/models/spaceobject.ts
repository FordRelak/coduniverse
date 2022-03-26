import { StarSystem } from "./star-system";

export class Spaceobject {
    constructor(
        public id: string,
        public name: string,
        public age: number,
        public type: number,
        public typeName: string,
        public starSystemId: string,
        public mass: number
    ) { }
}
