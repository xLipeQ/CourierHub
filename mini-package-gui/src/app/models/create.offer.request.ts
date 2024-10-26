import { TeamName } from "./team.name";

export class CreateOfferRequest {
    inquireId: number;
    teamName: TeamName;

    constructor(inquireId: number, teamName: TeamName) {
        this.inquireId = inquireId;
        this.teamName = teamName;
    }
}