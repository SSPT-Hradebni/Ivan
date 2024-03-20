import os

# Function to count lines in a file
def count_lines_in_file(file_path):
    try:
        with open(file_path, 'r', encoding='utf-8') as file:
            line_count = 0
            in_multiline_comment = False
            for line in file:
                line = line.strip()
                # Skip lines starting with C# comments
                if not line.startswith('//') and not in_multiline_comment:
                    if line.startswith('/*'):
                        in_multiline_comment = True
                    elif line.startswith('///'):
                        continue
                    else:
                        line_count += 1
                    if '*/' in line:
                        in_multiline_comment = False
                elif in_multiline_comment and '*/' in line:
                    in_multiline_comment = False
            return line_count
    except UnicodeDecodeError:
        # Try 'latin-1' encoding as a fallback
        with open(file_path, 'r', encoding='latin-1') as file:
            line_count = 0
            in_multiline_comment = False
            for line in file:
                line = line.strip()
                # Skip lines starting with C# comments
                if not line.startswith('//') and not in_multiline_comment:
                    if line.startswith('/*'):
                        in_multiline_comment = True
                    elif line.startswith('///'):
                        continue
                    else:
                        line_count += 1
                    if '*/' in line:
                        in_multiline_comment = False
                elif in_multiline_comment and '*/' in line:
                    in_multiline_comment = False
            return line_count

# Function to walk through directory and subdirectories
def count_lines_in_directory(directory):
    lines_info = []
    total_line_count = 0
    for dirpath, _, filenames in os.walk(directory):
        for filename in filenames:
            # Skip certain filenames
            if filename.endswith('.cs') and not any(exclude in filename for exclude in ["AssemblyAttributes", "AssemblyInfo", "GlobalUsings.g", "Designer"]):
                file_path = os.path.join(dirpath, filename)
                line_count = count_lines_in_file(file_path)
                lines_info.append((filename, line_count))
                total_line_count += line_count
    return lines_info, total_line_count

# Get the current directory
current_directory = os.getcwd()

# Count lines in all .cs files
lines_info, total_lines = count_lines_in_directory(current_directory)

# Read README.md content
readme_path = os.path.join(current_directory, 'README.md')
with open(readme_path, 'r', encoding='utf-8') as readme_file:
    readme_content = readme_file.read()

# Find the table placeholder in README.md
table_placeholder = "\n<!-- LINE COUNT TABLE -->"
start_index = readme_content.find(table_placeholder)
if start_index != -1:
    end_index = readme_content.find("\n<!-- END LINE COUNT TABLE -->", start_index)
    if end_index != -1:
        # Generate table content with file names and line counts
        table_content = "| Soubor | Počet řádků |\n|----------|------------|\n"
        for filename, line_count in lines_info:
            table_content += f"| {filename} | {line_count} |\n"
        
        # Replace the table content with new line count
        updated_readme_content = table_content + readme_content[end_index:]
        
        # Insert total line count above the table
        updated_readme_content = readme_content[:start_index + len(table_placeholder)] + f"{table_placeholder}\nTotal line count in all .cs files: {total_lines}\n\n" + updated_readme_content[start_index:]
        
        # Write the updated content back to README.md
        with open(readme_path, 'w', encoding='utf-8') as updated_readme_file:
            updated_readme_file.write(updated_readme_content)

print("README.md file has been successfully modified")
