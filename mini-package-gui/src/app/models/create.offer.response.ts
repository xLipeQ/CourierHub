import { TeamName } from "./team.name";

export class CreateOfferResponse {
    teamName: TeamName;
    price: number;
    inquireGuid: string;

    constructor(teamName: TeamName = TeamName.NONE, price: number = 0, inquireGuid: string = '') {
        this.teamName = teamName;
        this.price = price;
        this.inquireGuid = inquireGuid;
    }
}