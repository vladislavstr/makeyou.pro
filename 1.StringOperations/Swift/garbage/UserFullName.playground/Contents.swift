import UIKit

// 1
class User {

    // 2
    let FirstName: String
    let LastName: String
    let MidlName: String

    init(
        FirstName: String,
        LastName: String,
        MidlName: String
    ) {
        self.FirstName = FirstName
        self.LastName = LastName
        self.MidlName = MidlName
    }
    
    // 3
    func descriptionString() -> String {
        return "Hi, \(LastName) \(FirstName) \(MidlName)"
    }

}

let Hiuser = User(
    FirstName: "Vlad",
    LastName: "Str",
    MidlName: "Igor"
    )

// 8
print(Hiuser.descriptionString())
