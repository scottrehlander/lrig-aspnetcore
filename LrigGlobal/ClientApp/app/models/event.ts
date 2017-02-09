export class Event {
    constructor(
        public name: string,
        public chapter: string,
        public eventStart: Date,
        public eventEnd: Date,
        public eventbriteUrl: string,
        public additionalInfo: string,
    ) { }
}