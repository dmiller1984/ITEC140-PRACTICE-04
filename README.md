# ITEC140-PRACTICE-04 — Safety Check Summary

> **Independent practice only. This is not graded work and is not connected to a school repository.**

## New skills in this practice

This project combines TextBox input, RadioButtons, a CheckBox, **validation**, early exits from an event, and a formatted summary.

The instructions are detailed for the new validation steps but do not contain completed solution code.

## Finished result

The user enters a worker name, chooses a shift, marks whether the PPE inspection is complete, and selects **Create Summary**. The program validates the required information and displays a summary.

## Part 1 — Open the project and prepare the Designer

1. Clone and open `ITEC140-PRACTICE-04`.
2. Confirm the repository name in Solution Explorer.
3. Right-click `Form1.cs` and select **View Designer**.
4. Click the Form so the Designer is active.
5. Open **View → Toolbox** and **View → Properties Window** if they are hidden.
6. Set the Form's `Text` to `Practice 04 - Safety Check`.
7. Choose a size that leaves room for the controls and summary.

## Part 2 — Add the controls

| Control | (Name) | Text or starting value |
|---|---|---|
| Label | `lblWorkerPrompt` | `Worker name:` |
| TextBox | `txtWorkerName` | Empty |
| GroupBox | `grpShift` | `Shift` |
| RadioButton | `radDay` | `Day` |
| RadioButton | `radEvening` | `Evening` |
| RadioButton | `radNight` | `Night` |
| CheckBox | `chkPpeComplete` | `PPE inspection complete` |
| Button | `btnCreateSummary` | `Create Summary` |
| Label | `lblSummary` | Empty |

### Name input

1. Drag a Label and TextBox onto the Form.
2. Set their properties from the table.
3. Make the TextBox wide enough for a person's name.

### Shift selection

1. Drag the GroupBox onto the Form before adding the RadioButtons.
2. Name it `grpShift` and set its Text to `Shift`.
3. Click inside the GroupBox.
4. Drag Day, Evening, and Night RadioButtons **inside** it.
5. Set each RadioButton's Name and Text.
6. For this practice, leave all three `Checked` properties false so validation can detect a missing shift.

### PPE, button, and summary

1. Drag a CheckBox onto the Form and set its properties from the table.
2. Drag the Create Summary Button onto the Form and set its properties.
3. Drag a Label onto the Form for the output.
4. Name it `lblSummary` and clear its starting Text.
5. Make the output Label wide enough for the summary.
6. Arrange the controls clearly and save.

## Part 3 — Create the Click event

1. Select `btnCreateSummary`.
2. Open Properties → lightning-bolt **Events**.
3. Double-click beside `Click`.
4. Confirm the new event method refers to `btnCreateSummary`.

## Part 4 — Build the validation in order

Validation means checking the input before trying to produce the final summary. Write these sections one at a time and run the program after each section.

### Check 1 — Worker name

1. Read `txtWorkerName.Text`.
2. Remove extra spaces from the beginning and end before checking it.
3. If the result is blank:

   - display a friendly instruction in `lblSummary`;
   - return the typing cursor to `txtWorkerName`; and
   - stop the event at that point so no summary is created.

4. Test the blank-name case before continuing.

### Check 2 — Shift

1. Prepare a text value that will hold the selected shift.
2. Check `radDay.Checked`, `radEvening.Checked`, and `radNight.Checked`.
3. Store the matching shift name when one is selected.
4. If none is selected:

   - display a friendly instruction in `lblSummary`; and
   - stop the event before creating a summary.

5. Test a valid name with no shift before continuing.

### Check 3 — PPE status

1. Read `chkPpeComplete.Checked`.
2. Convert the true/false result into clear wording such as complete or not complete.
3. Do not require the CheckBox to be selected; both states are valid.

### Create the final summary

1. Combine the cleaned worker name, selected shift, and PPE wording.
2. Put that combined message into `lblSummary.Text`.
3. Do not automatically clear the inputs.

The sequence is the important part: validate the name, validate the shift, determine PPE status, then create the summary.

## Part 5 — Acceptance tests

| Test | Input | Expected result |
|---|---|---|
| 1 | Blank name | User is asked to enter a name |
| 2 | Name but no shift | User is asked to choose a shift |
| 3 | Name, Day, PPE checked | Summary shows the name, Day, and complete |
| 4 | Name, Night, PPE unchecked | Summary shows the name, Night, and not complete |

Run all four tests. Stop the program after testing.

## Part 6 — Commit and push

1. Open **View → Git Changes**.
2. Confirm all changed files belong only to Practice 04.
3. Commit with a message such as `Complete Practice 04 safety check`.
4. Push.
5. Refresh GitHub and verify your commit.

## Completion check

- [ ] Every RadioButton is inside `grpShift`.
- [ ] Blank-name validation works.
- [ ] Missing-shift validation works.
- [ ] Both PPE states produce correct wording.
- [ ] All four acceptance tests pass.
- [ ] I committed and pushed my work.

See [WORKFLOW-CHECKLIST.md](WORKFLOW-CHECKLIST.md) for the general workflow.
